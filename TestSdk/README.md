# TestSdk C# SDK 1.0.1

A C# SDK for TestSdk.

- API version: 1.0.0
- SDK version: 1.0.1

## Table of Contents

- [Authentication](#authentication)
- [Services](#services)

## Authentication

### Access Token

The test-sdk API uses a access token as a form of authentication.

The access token can be set when initializing the SDK like this:

```cs
// Constructor initialization
```

Or at a later stage:

```cs
// Setter initialization
```

## Services

### PetsService

#### **ListPetsAsync**

```csharp
using TestSdk;

var client = new TestSdkClient();

var response = await client.Pets.ListPetsAsync(85);

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
