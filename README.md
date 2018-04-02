# NoFraud

A .NET Library for using the [NoFraud](https://nofraud.co) IP VPN/TOR/Proxy detection service.

## Usage

A very basic example of how the module can be used
```
var Score = await V10Networks.FraudDetection.NoFraud.GetFraudScore(IPAddress.Parse("8.8.8.8"));

if (Score >= 0.1) {
// Your ban action here...
}

```

## Building

After cloning this repository, use either Visual Studio to build the project or the .NET Core SDK command line utilities to build the code in an assembly or a nuget package.