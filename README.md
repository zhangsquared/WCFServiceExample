# 3 Layer Desktop App

## TestServer

.NET Framework 4.7.2

*Self-Host in a Managed Application*

> Implements the host used by the Windows Communication Foundation (WCF) service model programming model.
> WCF services can be hosted in any managed application. This is the most flexible option because it requires the least infrastructure to deploy.

*Common Error:*

`HTTP could not register URL http://+:8080/TestService/. Your process does not have access rights to this namespace (see http://go.microsoft.com/fwlink/?LinkId=70353 for details).`

the HTTP address space is managed by a kernel driver called `http.sys`. 

To have requests forwarded to your process by `http.sys` requires registering the http namespace which is a privileged operation.

[Solution](https://stackoverflow.com/questions/8727293/http-could-not-register-url-http-8000-hellowcf-your-process-does-not-have)

* use the following command:

`netsh http add urlacl url=http://+:8080/TestService user=DOMAIN\user`

* "Run as Administrator" TestServer.exe

## Winform client

.NET Framework 4.7.2

`Add Service Reference...` 

Fill in the service Uri: `http://localhost:8080/TestService`

## Database (MySql, etc...)

> Not included in this example
