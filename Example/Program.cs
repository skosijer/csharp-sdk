using TestSdk;

var client = new TestSdkClient();

var response = await client.Pets.ListPetsAsync(81);

Console.WriteLine(response);
