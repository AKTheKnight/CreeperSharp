<p align="center">
<a href="https://ci.appveyor.com/project/AKTheKnight/creepersharp"><img src="https://ci.appveyor.com/api/projects/status/qtixt9xkn98xluvq/branch/master?svg=true" style="max-height: 300px;"></a>
<a href="https://www.microsoft.com/net"><img src="https://img.shields.io/badge/.NET%20Framework-4.7-orange.svg" style="max-height: 300px;"></a>
<img src="https://img.shields.io/badge/Platform-.NET-lightgrey.svg" style="max-height: 300px;" alt="Platform: iOS">
<a href="https://twitter.com/AKTheKnight"><img src="https://img.shields.io/badge/Twitter-@aktheknight-blue.svg?style=flat" style="max-height: 300px;"></a>
</p>

## About
CreeperSharp is a C# library that allows interfacing with the official CreeperHost api for the management of all services on a particular server. Below are some descriptions of the core parts of CreeperSharp

* **CreeperClient**: Handles accessing all endpoints related to the management of a specific server or game

## Features
* **CreeperClient**:
		* Handles server interactions and functionality
		* View statistics about the server
		* Allows scheduling of commands
		* Allows accessing billing data

## TO DO LIST

* Finish implementing the remainder of the CreeperHost API
* Create a form app for the management of a CreeperHost server

## Implementing
Below is a basic example of how to use the CreeperSharp library. This is just a subset of the capabilities of the API

#### CreeperClient
```csharp
using CreeperSharp;
using CreeperSharp.responses.server;

CreeperClient client;
ConnectionCredentials credentials = new ConnectionCredentials("api_ key", "api_secret");

client = new CreeperClient(credentials);

CPU cpu = client.GetCPU();

string model = cpu.Model;
```

## Installation

### [NuGet](https://www.nuget.org/packages/CreeperSharp/)

To install this library via NuGet via NuGet console, use:
```
Install-Package CreeperSharp
```
and via Package Manager, simply search:
```
CreeperSharp
```
You are also more than welcome to clone/fork this repo and build the library yourself!

## Issues

If you come across any issues while using the library or have any suggestions, feel free to create an issue with as much information as possible

## Dependencies

* Newtonsoft.Json 10.0.2+ ([nuget link](https://www.nuget.org/packages/Newtonsoft.Json/10.0.2)) ([GitHub](https://github.com/JamesNK/Newtonsoft.Json))
* RestSharp 105.2.3 ([nuget link](https://www.nuget.org/packages/RestSharp/105.2.3)) ([GitHub](https://github.com/restsharp/RestSharp/))

## License

This project is available under the MIT license. See the LICENSE file for more info.

