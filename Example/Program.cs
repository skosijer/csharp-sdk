using TestSdk;

var client = new TestSdkClient();

var response = await client.Pets.ListPetsAsync(47);

Console.WriteLine(response);
