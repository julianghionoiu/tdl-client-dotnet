[![Windows build Status](https://ci.appveyor.com/api/projects/status/github/julianghionoiu/tdl-client-dotnet?retina=true&svg=true)](https://ci.appveyor.com/project/julianghionoiu/tdl-client-dotnet)
[![NuGet](https://img.shields.io/nuget/v/TDL.Client.svg)](https://www.nuget.org/packages/TDL.Client/)

# tdl-client-dotnet
tdl-client-dotnet


# Installing

# Testing

All test require the ActiveMQ broker to be started.
The following commands are available for the broker.

```
python ./broker/activemq-wrapper.py start
python wiremock/wiremock-wrapper.py start 41375
python wiremock/wiremock-wrapper.py start 8222
```

Run tests with `?`.


# Cleanup

Stop external dependencies
```
python ./broker/activemq-wrapper.py stop
python wiremock/wiremock-wrapper.py stop 41375
python wiremock/wiremock-wrapper.py stop 8222
```


# To release

Run
```
./release.sh
```