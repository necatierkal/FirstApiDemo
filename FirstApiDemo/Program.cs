
/*//ASP.NET Core da api tasarlamanýn iki yolu var
1- Minimal API yöntemiyle
2- MVC tasarým deseni kullanarak
 
 */


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var app = builder.Build();

// Configure the HTTP request pipeline.
//Middlewarelar ve sýrasýný buraya yazýyoruz.

//Minimal api yöntemiyle bir api tasarlýyoruz.
app.MapGet("/", () =>
{
    return "Merhaba Dünya";
}); //get isteði.
//Bir pattern ve bir delege istiyor
//Bu get isteðini yaparsak kullanýcýya merhaba müþteri dönecek.
//Veri text olarak dönecek burada
//Biz jason olarak dönmesini tercih ederiz.

app.MapGet("musteriler", () =>
{
    return new[]
    {
        new
        {
            Id = Guid.NewGuid(),
            SirketAdi = "SLD Yazýlým",
            Kisi = "Salih DEMÝROÐ"
        },
        new
        {
            Id = Guid.NewGuid(),
            SirketAdi = "CAT Biliþim",
            Kisi = "Cüneyt TAHMAZ"
        },
        new
        {
            Id = Guid.NewGuid(),
            SirketAdi = "Kodlama IO",
            Kisi = "Engin DEMÝROÐ"
        }
    };
});


app.Run();

