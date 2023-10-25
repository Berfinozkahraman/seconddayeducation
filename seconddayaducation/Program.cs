// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// veri yapıları
//string r = "Berfin";
//r += "Özkahraman";
// işaretçi veri tipi
//sayısal bir veri değeri atayabilmek için süslü parantez içerisine 0 yazarız stringin içerisine int değer atayabiliyoruz. 

int m = 10;
int p = 20;
int sonuc = m*p;
Console.WriteLine("Deger ; {0}", sonuc);
// operatörler
// == operatörü Equel To operatörü, verilen iki işlenenin eşit olup olmadığını kontrol eder. eğer öyleyse doğru döndürür.
// break ifadesi döngüyü kırıyor.
// bağlamsal anahtar kelimeler fonksiyon olarak kullanılmayan , kod bloğundaki bağlama göre anlam kazanan kelimeler
// get'le komutu alıp set'le orayı değiştirebiliyoruz.
// karar yapısı if, sürdürülebilirlikte while kullanılır.


//int x = 1;

//while (x <= 4)
//{
//    Console.WriteLine("berfinozkahraman");
//    x++;
//}
// if ifadesinde şart kontrol ettiriliyor. karar ifadesi varsa bir koşul varsa 
// while ifadesinde süreklilik devam ettirmek istediğimiz zaman kullanılır.
//string name = "berfin";
//if (name = "berfin") ;




// else ifte eğer değilse şartı varsa kullanılır
int x = 15;
if (x == 10)
    Console.WriteLine("x = 10 dur");
else if (x == 15)
    Console.WriteLine("x = 15 tir");
else if (x == 20)
    Console.WriteLine("x = 20 dir");
else
    Console.WriteLine("x tanımlanamadı");


// ifte iç içe döngü kullanabiliyoruz birinciyi sağladıktan sonra diğer şarta bakılır 
int i = 10;
if (i == 10)
    if (i < 12)
        Console.WriteLine("i 12 den küçüktür");
    else
        Console.WriteLine("i 15 ten büyüktür");
// clean code: a handbook of agile software craftsmanship bu kitaba bak
// switch aldığımız değer case o değere içerik gelen ifade (değerleri kontrol ettiriyoruz)
// switch case yapısı bellir bir noktadan sonra döngüden çıkması lazım

int number = 40;
switch (number)
    case 10:
    Console.WriteLine("case 10");
    break;
 case 20:
    Console.WriteLine("case 20");
    break;
 case 30:
    Console.WriteLine("case 30");
    break;
 default:
    Console.WriteLine("Eslesme yok");
    break;



    //  app.AppGet("/") veya home ifadesi anasayfada olduğumuzu belirtir
    //değer veri yapısı char 
    // char karakter 
    // int değer atama tam sayılar
    // uint ushort
    // double float değeri yazıldıktan sonra f koyulur ayrım için double daha büyük sayılar için temel yapılar için float

    //referans veri tipi

    String r = "Aleyna";
    r += "Kanat";
    r = r + "Aleyna";
    Console.WriteLine(r);

    //işaretçi veri tipi
    int m = 10;
    int p = 20;
    int sonuc = m * p;
    Console.WriteLine("Deger: {0}", sonuc);

    //operatörler
    // == verilen işlenenin eşit olup olmadığını kontrol eder aksi halde false olur
    // != veriler eşitse false döndürür değilse true döndürür
    // > < büyüktür küçüktür
    // <= >= büyük eşit küçük eşit

    // else değilse for için 
    // go to atlama
    // bağlamsal anahtar kelimeler
    //  var= variable değişken değer int veya başka bir şey yerine var string hata payını azaltır
    // get ve set get ile komut alınıp set ile uygulanır ayarlanır modalda yazılır

    int x = 1;
    while (x <= 4)
    {
        Console.WriteLine("aleynakanat");
        x++;
    }

    //karar durumlarında if kullanılır, sürdürebilir şartlar sağlanana kadar işin yapılması için while kullanılır
    string name = "Aleyna";
    if (name == "Aleyna")
    {
        Console.WriteLine("Aleyna Kanat");
    }

    //if else yapısı
    int y = 15;
    {
        if (y == 10)
            Console.WriteLine("y 10dur");
        else if (y == 15)
            Console.WriteLine("y 15tir");
        else
            Console.WriteLine("y tanımlanamadı");
    }

    int i = 10;
    if (i == 10)
    {
        if (i < 12)
            Console.WriteLine("i 12den küçüktür");
        else if (i > 12)
            Console.WriteLine("i 12den büyüktür");
    }

    // switch case, şart kontrolüdür, switch istediğimiz değerdir case ise bunu kontrol eder case'den sonra ":" iki nokta kullanılır 
    int numb = 40;
    switch (numb)
    {
        case 10:
            Console.WriteLine("case 10");
            break;
        case 20:
            Console.WriteLine("case 20");
            break;
        default:
            Console.WriteLine("eslesme yok");
            break;
    }
// eşleşme olsa bile mutlaka break kullanılmalıdır   
