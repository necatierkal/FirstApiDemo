
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

//app.MapGet("musteriler", () =>
//{
//    return new[]
//    {
//        new
//        {
//            Id = Guid.NewGuid(),
//            SirketAdi = "SLD Yazýlým",
//            Kisi = "Salih DEMÝROÐ"
//        },
//        new
//        {
//            Id = Guid.NewGuid(),
//            SirketAdi = "CAT Biliþim",
//            Kisi = "Cüneyt TAHMAZ"
//        },
//        new
//        {
//            Id = Guid.NewGuid(),
//            SirketAdi = "Kodlama IO",
//            Kisi = "Engin DEMÝROÐ"
//        }
//    };
//});


//app.MapGet("musteriler/1", () =>
//{
//    return new
//    {
//        Id = Guid.NewGuid(),
//        SirketAdi = "SLD Yazýlým",
//        Kisi = "Salih DEMÝROÐ"
//    };
//});
//app.MapGet("musteriler/2", () =>
//{
//    return new
//    {
//        Id = Guid.NewGuid(),
//        SirketAdi = "CAT Biliþim",
//        Kisi = "Cüneyt TAHMAZ"
//    };
//});
//Id si 1 olan müþteriyi getirir
//musteriler/1 bir root tanýmý
//Parametrik tanýmlanabilir.


//app.MapGet("musteriler/{id}", (int id) => //id olarak ne gönderirsen gönder hata vermeden çalýþacak. Verdiðin parametre deðerini id olarak alýr.
////int id deðiþkeninin yazdý çünkü 
////Bir route a(endpointe) gidildiðinde bir parametre varsa; model binding dediðimiz bir mekanizma devreye girer. Bu model binding bir parametre varsa bu parametreyi set etmeye çalýþýr.
//// Model binding sýrasýyla form fields, request body, route data, query string parametreleri uploaded files a bakar. Sýradan ilk deðer bulduðunda diðerlerine bakmaz.
////Bizim örnekte id isimli deðiþken route data da veriliyor. isimlerin eþleþmesi önemli.
////Bunlara hizmet ya da endpoint denir.
//{
//    return new
//    {
//        Id = id,
//        SirketAdi = "SLD Yazýlým",
//        Kisi = "Salih DEMÝROÐ"
//    };
//});



app.MapGet("musteriler/{id:int}", (int id) => //Burada id parametresine int constrainti ekledik. Artýk badrequest deðil servera gitmeden not found hatasý verir.
{
    return new
    {
        Id = id,
        SirketAdi = "SLD Yazýlým",
        Kisi = "Salih DEMÝROÐ"
    };
}); // Orta ve büyük ölçekli projelerde minimal api yazýlmamalý. Bakým maliyeti artar. MVC deseni kullanarak tasarlanmalý.

app.Run();

