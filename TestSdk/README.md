# TestSdk C# SDK 1.0.0

A C# SDK for TestSdk.

- API version: 1.0.0
- SDK version: 1.0.0

## Table of Contents

- [Authentication](#authentication)
- [Services](#services)

## Authentication

### Access Token

The test-sdk API uses a access token as a form of authentication.

The access token can be set when initializing the SDK like this:

```cs
using TestSdk;
using TestSdk.Config;

var config = new TestSdkConfig()
{
	AccessToken = "YOUR_ACCESS_TOKEN"
};

var client = new TestSdkClient(config);
```

Or at a later stage:

```cs
client.SetAccessToken("YOUR_ACCESS_TOKEN")
```

## Services

### PetsService

#### **ListPetsAsync**

```csharp
using TestSdk;

var client = new TestSdkClient();

var response = await client.Pets.ListPetsAsync(34);

Console.WriteLine(response);
```

#### **CreatePetsAsync**

```csharp
using TestSdk;
using TestSdk.Models;

var client = new TestSdkClient();

var input = new Pet(8, "name");

await client.Pets.CreatePetsAsync(input);
```

#### **ShowPetByIdAsync**

```csharp
using TestSdk;

var client = new TestSdkClient();

var response = await client.Pets.ShowPetByIdAsync("petId");

Console.WriteLine(response);
```
