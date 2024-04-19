
/*//ASP.NET Core da api tasarlaman�n iki yolu var
1- Minimal API y�ntemiyle
2- MVC tasar�m deseni kullanarak
 
 */


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var app = builder.Build();

// Configure the HTTP request pipeline.
//Middlewarelar ve s�ras�n� buraya yaz�yoruz.

//Minimal api y�ntemiyle bir api tasarl�yoruz.
app.MapGet("/", () =>
{
    return "Merhaba D�nya";
}); //get iste�i.
//Bir pattern ve bir delege istiyor
//Bu get iste�ini yaparsak kullan�c�ya merhaba m��teri d�necek.
//Veri text olarak d�necek burada
//Biz jason olarak d�nmesini tercih ederiz.

app.MapGet("musteriler", () =>
{
    return new[]
    {
        new
        {
            Id = Guid.NewGuid(),
            SirketAdi = "SLD Yaz�l�m",
            Kisi = "Salih DEM�RO�"
        },
        new
        {
            Id = Guid.NewGuid(),
            SirketAdi = "CAT Bili�im",
            Kisi = "C�neyt TAHMAZ"
        },
        new
        {
            Id = Guid.NewGuid(),
            SirketAdi = "Kodlama IO",
            Kisi = "Engin DEM�RO�"
        }
    };
});


app.Run();

