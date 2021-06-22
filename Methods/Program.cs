using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methodlar bizim için tekrar tekrar kullanılabilirliği sağlayıyor
            //Kendimizi tekrar etmemek için do not repeat yourself prensibini biz methodlarla çözeriz
            //Eğer yazdıığınız bir kod bloğunu tekrar ediyorsanız aynı kodu 3 sayfada yazdı iseniz herhangi
            //bir değişiklik talebinde o zaman 1 iş yerine 3 tane ayrı ayrı iş yapman gerekecektir onun için aynı
            //kkodları sürekli yazmak yerine onları method haline getirmeliyiz
            //Best Practise=>Doğru uygulama teknikleri
            //C# ve Java dillerinde herşey class lar içerisine yazılır class tabanlı bir dildir çünkü C#
            //Class isimlemdirmeler i PascalCase ile yani ilk harfi büyük olarak yazılır(convention)

            //CLASS I NEDEN NEWLERİZ?
            //Biz nasıl ki string den veri oluştururken string elmaTuru="Amasya Elması" diyorsak burda da Class türünden bir instance
            //tanımlamak için new lememiz gerekiyor çünkü class dediğimiz yapıdan değişken tanımalamak bu yöntemle olur, class içerisinde
            //birçok türden veriyi tanımladığından dolayı. Yani strin doğrudan veriyi yazar çünkü elinde sadece string türünde tek bir veri
            //vardır , class ta ise hem elimizde birden fazla veri bulunmaktadır hem de farklı türlerde veri bulunmaktadır dolayısı ile bizim
            //class üzerinden instanceler oluşturarak onları değişkene atarız

            Product product1 = new Product() { ProductId = 1234, ProductName = "Elma", ProductPrice = 5.4, ProductInfo = "Tatlı Elma" };
           //product1 demek Elma ile ilgili tüm verilein olduğu class instancesi veya class nesnesidir yani paket bir değişken
            
            Product product2 = new Product();
            product2.ProductId = 1235;
            product2.ProductName = "Armut";
            product2.ProductPrice = 6.5;
            product2.ProductInfo = "Anamur Armutu";
            product2.ProductStockNumber = 9876;

            Product product3 = new Product();
            product3.ProductId = 1236;
            product3.ProductName = "Karpuz";
            product3.ProductPrice = 7.4;
            product3.ProductInfo = "Diyarbakir Karpuzu";

            Product product4 = new Product() { ProductId = 1237, ProductName = "Erik", ProductPrice = 4.5, ProductInfo = "Yerli Erik" };
            //Evet burda şuna dikkat edelim biz normalde bu verileri ayrı ayrı string lerde tutmayı düşündüğümüzdeki en büyük
            //problemimiz biz bu farklı tür verilerin aynı ürünün verileri olduğu konusunda eğer class kullanmazsak ilişkilendirmekte
            //zorlanıyoruz hani verileri aynı ürünü temsil ediyor bunu çözemiyorduk normal doğrudan string,int vs ile bu verileri
            //tanımlasaydık eğer ama class lar sayesinde biz bir ürünümüze ait farkı tür özellik leri farklı tür verileri bir
            //arada tutabilmeyi başarıyoruz işte burası mükemmel kullanışlı
            //Nasıl ki bir stringden birden fazla değişken oluşturuyorsak burda da Product class tipimizden de
            //birden fazla nesne,instance oluşturabileceğiz
            //Nasıl ki string array oluşturabiliyorsak Product class ımızın array ini de oluşturabiliriz

            Product[] products1 = new Product[] { product1, product2 };
            Product[] products2 = new Product[2];//Kac veri icine atacaksk belirtmeliyiz
            products2[0] = product3;
            products2[1] = product4;

            //Ama suraya cok dikkat edelim biz burda Product class imizdan array olusturdugumuz zaman icerisinde sadece,
            //o class imizdan olusturudgumuz instanceleri ya da nesneleri atabliriz, yani herhangi bir string veya int
            //atamayiz Product class imizla oljusturulmus verimize
            //Ama sunu unutmayalim biz normalde biz urunleri elimizle yaziyoruz burda ama biz bu verileri bir veri kaynagindan
            //alacagiz bir veri tabani , bir api, bir excel dosyasi veya bir text dosyasindan cekecegiz gercek hayatta

            
            //Dikkat edelim  biz foreach veri tipine Product yazdık çünkü biz Product class ından oluşturulmuş instanceleri
            //içeren bir array i dönderiyoruz dolayısı ile veri tipimiz Product class ı o yüzden ordaki var yerine Product
            //class veri tipini yazarız ki normalde "var" da aslında tüm veri tipleri ile uyumlu çalışan bir veri tipidir
            //yani arka planda var veri tipi bu veri tipini yine Product class veri tipine çeviriyor
            //ama biz yine de buraya Product class veri tipimizi yazalım

            //Peki C# veya Java da neden heryere veri tipini yazıyoruz çünkü bu diller tip güvenli dillerdir
            //type-safe -tip güvenli - bu diller hangi tiplerle çalışmak istediğini bilmek istiyorlar
            foreach (Product product in products1)
            {
                Console.WriteLine(product.ProductId);
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.ProductPrice);
                Console.WriteLine(product.ProductInfo);
                Console.WriteLine(".......................................");
                //Burda biz ekranda yazdıımızı görmek için Console.WriteLine yapıyoruz ama normal hayatta
                //burda biz html kodu olan <li> {} </li> içerisine yazacağız
                //Normal e-ticaret web uygulamalarında angular,react,bootstrap,html ile görselleştiriyor
            }
            Console.WriteLine("///////////////////////////////////////////////////////////////////7");
            foreach ( var product in products2)
            {
                Console.WriteLine(product.ProductId);
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.ProductPrice);
                Console.WriteLine(product.ProductInfo);
                Console.WriteLine(".......................................");
            }

            Console.WriteLine("----------BASKETMANAGER CLASINDAKİ ADD METHODUNU ÇAĞIRMA----------------");

            //Önce bir BasketManager class örneği oluştururuz biz bu class ımızdan bir sürü BasketManager instancesi oluşturabiliriz eğer istersek
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            //Biz bu basketmanager.Add() methodunu farklı farklı sayfalarda defalarca kullanabiliriz
            //reusability-tekrar tekrar kullanabilme
            //Örnek bize dediler ki veri eklendi ye metin eklememiz istendi sonuna ! koyacağız mesela ne yapıyoruz doğruca bu
            //BasketManager class ına gideriz ve orda Add methodunda değişikliğimi yaptıktan sonra bizim bu methodu çalıştırıdğımız
            //tüm sayfalar da aynı anda değişikliği görebiliriz yani burda aslında biz kodlarımızı tek merkezden yönetiyoruz ve her
            //birisi için ayrı ayrı sayfalara gidip düzeltmemize gerek kalmıyor
            Console.WriteLine("----------------------------------------");
            basketManager.Add(product2);
            Console.WriteLine("-----------------------------------------");

            basketManager.Add(product3);
            Console.WriteLine("----------------------------------------------------");
            basketManager.Add(product4);
            Console.WriteLine("-------------------------------------------------");

            Console.ReadLine();
        }
    }
}
//CLASS
//Classlar,propertyler ve methodlar ya da interface ler hep PascalCase ile yani ilkharf büyük olarak yazılır
//1)Property tutmak için(ürün id,ürün adı, ürün fiyat, ürün acıklama veya customerId,customerName,customerType

//Class lar iki amaç için kullanılıyor bir tanesi özellik eklemek için ondan dolayı zaten class ımzızın adı product veya customer ,
//person gibi isimler veriyoruz özellik, property eklemek için
//Ayrıca biz eklediğimiz bir özelliğe ilk id ekliyoruz aynı tc kimlik numarası gibi o ürünü kendine has kılan , benzersiz kılan bir
//numaradır ki biz bir müşteriye tc bile versek id veririz id olmazsa olmazdır
//Biz ürün özelliklerini property lerle tanımlarız
//2) Class ların diğer kullanımı ise operasyon veya method denilen isim olarak da SepetManager,Service,Dal,Dataacces,Controller
//gibi ifadeler bir operasyon tutuyor demektir
//Biz operasyonlarımızı method olarak gruplandırarak class larımızda tutarız mesela sepetteki ürünleri listeleme methodu,
//veya sepete ürün ekleme gibi methodları class da tutarız