using TestSdk;

var client = new TestSdkClient();

var response = await client.Pets.ListPetsAsync(34);

Console.WriteLine(response);
