# Dusty's Corner

This is a website I created for a company that manufactures miniature scale models.

It was developed in Visual Studio 2022 using the following technologies:

* ASP.NET Core
* MVC / Web API
* Entity Framework
* AngularJS
* Bootstrap

You can view the finished website <a href='https://www.dustyscorner.com' target='_new'>here</a>.

Here are some screenshots of the website:

<img align='left' src='https://drive.google.com/uc?id=1eu5gka6dhN4wQ-AVy-EKribgu-PjBKct' width='240'>
<img align='left' src='https://drive.google.com/uc?id=11AweYaTgiTsGFIAC4JjhSKASLZoZlMYe' width='240'>
<img src='https://drive.google.com/uc?id=1S5EHed6dv4JDqFyde3po_g7swD98wSna' width='240'>

# Database

You must first define the connection string for the database. In the Solution explorer expand the DustysCorner.DAL project and open the StoreContext.cs file. In the OnCofiguring method you will find the connection string which should look like this:

`@"Data Source=YOUR_SERVER_NAME;Initial Catalog=DustysCorner;Persist Security Info=True;User ID=YOUR_USERNAME;Password=YOUR_PASSWORD"`

Replace the data source, user id and password with your own database account credentials.

The database will be created and seeded automatically using the StoreDataInitializer class in development mode when you run the DustysCorner.Service project.

If you need to make changes to the database structure you can create a new migration script using the command from the Tools->NuGet Package Manage->Package Manager Console:

```
dotnet ef migrations add <migration name> -c DustysCorner.DAL.StoreContext
```

# Running the Project

To run the website project in development mode you must first right click on the Solution Name in the Solution Explorer. In the Startup Project page you should select Multiple Startup Projects and change the Action for DustyCorner.MVC and DustysCorner.Service to Start. You can now click the run button and both projects will start.

# Note

This is a project I created to help me learn AngularJS. I realise the API methods should normally be requested from the Angular controllers instead of initializing with JSON using ng-init on the views. I did this simply to demonstrate using the ASP.NET MVC framework and is not a recommended approach. Since creating this project I have learnt Angular 2+ which is a much better framework. Feel free to modify as you need.
