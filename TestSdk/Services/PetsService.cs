using System.Net.Http.Json;
using TestSdk.Http;
using TestSdk.Http.Serialization;
using TestSdk.Models;

namespace TestSdk.Services;

public class PetsService : BaseService
{
    internal PetsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <param name="limit">How many items to return at one time (max 100)</param>
    public async Task<List<Pet>> ListPetsAsync(long? limit = null)
    {
        var request = new RequestBuilder(HttpMethod.Get, "pets")
            .SetOptionalQueryParameter("limit", limit)
            .Build();

        var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<List<Pet>>(_jsonSerializerOptions)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    public async Task CreatePetsAsync(Pet input)
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "pets")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <param name="petId">The id of the pet to retrieve</param>
    public async Task<Pet> ShowPetByIdAsync(string petId)
    {
        ArgumentNullException.ThrowIfNull(petId, nameof(petId));

        var request = new RequestBuilder(HttpMethod.Get, "pets/{petId}")
            .SetPathParameter("petId", petId)
            .Build();

        var response = await _httpClient.SendAsync(request).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<Pet>(_jsonSerializerOptions)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
