
/*//ASP.NET Core da api tasarlaman�n iki yolu var
1- Minimal API y�ntemiyle
2- MVC tasar�m deseni kullanarak
 
 */


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var app = builder.Build();

// Configure the HTTP request pipeline.
//Middlewarelar ve s�ras�n� buraya yaz�yoruz.





app.Run();

