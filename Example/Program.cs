using TestSdk;

var client = new TestSdkClient();

var response = await client.Pets.ListPetsAsync(79);

Console.WriteLine(response);
