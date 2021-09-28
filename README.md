# serilog-config-sample

An asp-dotnet-core example that leverages Serilog as the logging framework.

This example is establishing a minimum viable example for logging with focus on one log record per request. 

The one log record should contain these details 
timestamp, log level, message, verb, path, response status code, elapsed time, any additional properties such as application name or transactionId

The sample is focusing on configuring the framework using the appsettings.json file(s) to ease external configuration without code changes! 

Feel free to issue Pull Requests
