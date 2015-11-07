# Tips on how to use the templates
In order to use fast the template it is better to **rename** all the necessary things. You should open the given files **as text** and replace **"WebApiTemplate"** with the base name of your project. All you have to rename is:
 1. The solution of the project - **.sln**
 2. The project file of every project - **.csproj**
    - .Data project 
    - .Models project 
    - .Api project
    - .Services.Data project
 3. The assembly properties of every project - **/Properties/AssemblyInfo.cs**: 
    - .Data project
    - .Models project
    - .Api project
    - .Services.Data project
 4. The **Global.asax** file - the starting point of the application
 5. The **Web.Config** file - should customize the connection string.

Also you should **rename all the namespaces** when you open the project. Then - voila, you have a high quality web api skeleton, high level of abstraction, high cohesion, loose coupling, all you have to do is add the code first models, add the IDbSets in the I...DbContext and the Controllers. 

# Contents of the template: 
1. Separated Data layer (.Data and .Models) for code first database creation
2. ASP.NET WebApi 2 application, cleaned mostly from the MVC dependencies
3. Service provider (.Services.Data) - Used by the controller to get info from database
 
## What is used in the project:
- Code first database creation
- Automatic database migrations
- Repository pattern 
- Enabled Cors
- IoC using Ninject
- AutoMapper
- Microsoft Individual user accounts


This template is based on the [Telerik's Software Academy](http://telerikacademy.com/) Workshop **"ASP.NET Web API architecture and design"**
- [Video of the demo](https://www.youtube.com/watch?v=gaknr3TnpTI)
- [Source code of the demo](https://github.com/TelerikAcademy/Web-Services-and-Cloud/tree/master/03.%20ASP.NET-Web-API-Architecture/LiveDemo-2015-SourceControlSystem)
- [The Web Services and Cloud course at Telerik Academy](http://telerikacademy.com/Courses/Courses/Details/275)
