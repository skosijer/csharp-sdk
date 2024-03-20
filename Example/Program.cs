using TestSdk;

var client = new TestSdkClient();

var response = await client.Pets.ListPetsAsync(85);

Console.WriteLine(response);
