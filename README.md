.NET core console application showing how to hide or mask attributes of an object included in logs that are written using Serilog.

 - Logs are sent to Azure Application Insights using [Serilog
   Application Insights
   Sink](https://github.com/serilog/serilog-sinks-applicationinsights) library.
 - PII data is masked using
   [Destructurama.Attributed](https://github.com/destructurama/attributed)
   library.

***Note:*** Before executing the application, update the Application Insights instrumentation key in appsettings.json file with a  valid value.
