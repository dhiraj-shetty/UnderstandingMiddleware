<b>Understanding Middleware in .NET Core WebAPI</b> <br>
<br>
<b>System Requirements:</b> <br>
<br>
Visual Studio 2019 latest version <br>
.Net 5.0 SDK <br>
<br>
<b>Why Middleware:</b> <br>
<br>
An intuitive guess would be to assume that every request from the User/Browser goes directly to our Controllers (for further processing). Factually, the .NET Core WebAPI framework allows us to add code in between through addition of Middleware in the HTTP request pipeline. We can have an infinite number of middelware. However the order of the middleware is crucial. <br>
<br>
<b>Programming Middleware:</b> <br>
1. Use() method to insert a new middleware in the pipeline
2. Next() method to call the next middleware in the pipeline
3. Map() method to map the middleware only to a specific URL.
4. Run() method to complete the execution of the HTTP Request Pipeline
<br>
Middelware implemented in a typical ASP.NET Core WebAPI include Routing, Authentication, Addition of Developer Exception Page etc
<br>

