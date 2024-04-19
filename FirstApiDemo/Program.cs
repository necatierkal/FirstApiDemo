
/*//ASP.NET Core da api tasarlamanýn iki yolu var
1- Minimal API yöntemiyle
2- MVC tasarým deseni kullanarak
 
 */


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var app = builder.Build();

// Configure the HTTP request pipeline.
//Middlewarelar ve sýrasýný buraya yazýyoruz.





app.Run();

