using TestSdk;

var client = new TestSdkClient();

var response = await client.Pets.ListPetsAsync(24);

Console.WriteLine(response);
