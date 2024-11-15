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

You will need to download the ASP.NET v6.0 framework to run the project. The installer can be found [here](https://drive.google.com/file/d/11zncsDcBwREHhEhSzAAK4QLPisN7hSM6/view?usp=sharing)

I would recommend that you search for Visual Studio 2022 in the Start Menu then run it as Administrator to avoid any errors starting the IIS Express server:

1. Right click on the Visual Studio 2022 main application shortcut choose Properties
2. Click the Shortcut tab
3. Click the Advanced... button
4. Check the Run as administrator checkbox

You may need to edit the web projects Debug settings.

1. Right click on the web project you need to edit the settings for
2. Select Properties
3. Select the Debug -> General tab and Open debug launch profiles UI
4. Check the App URL is using a free port
5. Change the Hosting Model to In Process
6. Uncheck Use SSL

To run the website project in development mode you must first right click on the Solution Name in the Solution Explorer. In the Startup Project page you should select Multiple Startup Projects and change the Action for DustyCorner.MVC and DustysCorner.Service to Start. You can now click the run button and both projects will start.

# Note

This is a project I created to help me learn AngularJS. I realise the API methods should normally be requested from the Angular controllers instead of initializing with JSON using ng-init on the views. I did this simply to demonstrate using the ASP.NET MVC framework and is not a recommended approach. Since creating this project I have learnt Angular 2+ which is a much better framework. Feel free to modify as you need.
