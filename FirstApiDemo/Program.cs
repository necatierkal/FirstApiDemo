
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

//app.MapGet("musteriler", () =>
//{
//    return new[]
//    {
//        new
//        {
//            Id = Guid.NewGuid(),
//            SirketAdi = "SLD Yaz�l�m",
//            Kisi = "Salih DEM�RO�"
//        },
//        new
//        {
//            Id = Guid.NewGuid(),
//            SirketAdi = "CAT Bili�im",
//            Kisi = "C�neyt TAHMAZ"
//        },
//        new
//        {
//            Id = Guid.NewGuid(),
//            SirketAdi = "Kodlama IO",
//            Kisi = "Engin DEM�RO�"
//        }
//    };
//});


//app.MapGet("musteriler/1", () =>
//{
//    return new
//    {
//        Id = Guid.NewGuid(),
//        SirketAdi = "SLD Yaz�l�m",
//        Kisi = "Salih DEM�RO�"
//    };
//});
//app.MapGet("musteriler/2", () =>
//{
//    return new
//    {
//        Id = Guid.NewGuid(),
//        SirketAdi = "CAT Bili�im",
//        Kisi = "C�neyt TAHMAZ"
//    };
//});
//Id si 1 olan m��teriyi getirir
//musteriler/1 bir root tan�m�
//Parametrik tan�mlanabilir.


//app.MapGet("musteriler/{id}", (int id) => //id olarak ne g�nderirsen g�nder hata vermeden �al��acak. Verdi�in parametre de�erini id olarak al�r.
////int id de�i�keninin yazd� ��nk� 
////Bir route a(endpointe) gidildi�inde bir parametre varsa; model binding dedi�imiz bir mekanizma devreye girer. Bu model binding bir parametre varsa bu parametreyi set etmeye �al���r.
//// Model binding s�ras�yla form fields, request body, route data, query string parametreleri uploaded files a bakar. S�radan ilk de�er buldu�unda di�erlerine bakmaz.
////Bizim �rnekte id isimli de�i�ken route data da veriliyor. isimlerin e�le�mesi �nemli.
////Bunlara hizmet ya da endpoint denir.
//{
//    return new
//    {
//        Id = id,
//        SirketAdi = "SLD Yaz�l�m",
//        Kisi = "Salih DEM�RO�"
//    };
//});



app.MapGet("musteriler/{id:int}", (int id) => //Burada id parametresine int constrainti ekledik. Art�k badrequest de�il servera gitmeden not found hatas� verir.
{
    return new
    {
        Id = id,
        SirketAdi = "SLD Yaz�l�m",
        Kisi = "Salih DEM�RO�"
    };
}); // Orta ve b�y�k �l�ekli projelerde minimal api yaz�lmamal�. Bak�m maliyeti artar. MVC deseni kullanarak tasarlanmal�.

app.Run();

