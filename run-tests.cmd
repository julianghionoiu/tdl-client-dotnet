python37 wiremock/wiremock-wrapper.py start 41375
python37 wiremock/wiremock-wrapper.py start 8222
python37 broker/activemq-wrapper.py start

nunit3-console test/specs/bin/Release/TDL.Test.Specs.dll
SET TestResult=%ERRORLEVEL%

python37 wiremock/wiremock-wrapper.py stop 41375
python37 wiremock/wiremock-wrapper.py stop 8222
python37 broker/activemq-wrapper.py stop

EXIT %TestResult%
