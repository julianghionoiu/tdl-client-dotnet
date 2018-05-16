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

# Hack and gotchas for `mono` and `.Net`

1. I had to place FSharp.Core into the GAC

For some reasons, mono was not finding FSharp.Core.dll.
I have used `gacutils` to add the library into the General Assembly Cache.

2. SpecFlow generateAll task fails with `msbuild`

When you first run `msbuild tdl.sln` the SpecFlow task will fail. The .cs files are still generated correctly but the results is not reported back to msbuild.
This means that you have to run `msbuild tdl.sln` twice.

3. RestSharp sometimes return a status code of 0

One test always fails on OSX with Mono. RestSharp fails to read the request body correctly. The same test passess on the CI system.
The test seems to be related to the fact that we have received an errorStatus code with a body.

