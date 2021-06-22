using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class BasketManager
    {
        //2) Class ların diğer kullanımı ise operasyon veya method denilen isim olarak da SepetManager,Service,Dal,Dataacces,Controller
        //gibi ifadeler bir operasyon tutuyor demektir
        //Biz operasyonlarımızı method olarak gruplandırarak class larımızda tutarız mesela sepetteki ürünleri listeleme methodu,
        //veya sepete ürün ekleme gibi methodları class da tutarız
        //Sepete 
        //Yazım kuralı naming convention-isimlendirme kuralı demektir
        //Methodlar PascalCase isimlendirme tekniği ile yani baş harf büyük olacak şekilde yazarız
        //Biz iki şekilde method oluştururuz 1-return olarak geriye bir değer döndüren methodlar onlarla başlarken veri
        //tipini yazarak methodu isimlendiririz public int KareAlma(){}
        //Diğer method tipimizde void ile olan methodda ise işlem yapar ama geriye veri döndermeyen methodlardır
        //Add,Delete,Update gibi işlemleri yapar ve geriye verri dönmez public void Add(){}
        //naming convention-isimlendirme kuralı dır-methodlar büyük harfle başlamalı-class,property,method,interface
        // Eğer büyük harfle başlayan bir yazının yanında Add() böyle birşey varsa bu kensinlikle bir methoddur bunu unutmayalım


        //CLASSLARDA YAZDIIĞIMIZ METHODLARDA PARAMETRE NEYE GÖRE KULLANILIR?
        //E-ticaret sitelerinde yanyana ve alt alta ürünler listelenir ve o ürünlerin hepsinde de sepete ekle vardır ama her ürün ün
        //id si farklı dır dolayısı ile bir müşteri sepeteEkle dediğinde burda BasketManager ı çalıştıracak ama her ürün kendine hass
        //bir üründür yani peki biz basılan ürünün hangi ürün olduğunun nerden buluyoruz işte onu da verilen parametreden ayırt ederiz
        //hangi ürünü ekleyeceğini biz gelen parametreden ayırt ederiz ki o  parametrede yine muhtmelemen bir veri kaynağından gelecektir
        //C# dili type safe- tip güvenli bir dil olduğu için herzaman tipini görmek istiyor C# onun için parametreye biz verimizin
        //tipi ni ve değişken ismini yazarız ki burda tabi ki biz property lerimizi eklediğimiz Product class tipimiz ile product
        //adlı onun instancesinii temsil eden bir değişken ismi ile yazacağız
        //Operasyonlarda parametreye biz herzaman property class larımızı yazarı bu çok önemlidir buna aşina olalım

        //Parametreye property class ımız ve onun instance ismini temsil eden Add(Product product) product şeklinde yazdıktan sonra
        //biz bu methodu nerde kullanacağız ana class Program.cs clasında Main methdounun içinde dolayısı ile biz Product class ımız
        //yani properties leri tuttuğumuz class larımızdan instancelerimizi de yine ana class ımız Program.cs ve Main methodunda
        //oluşturdğumuz için işte artık olşturduğumuz instanceleren hangisin istersek onu parametre olarak verebiliriz eğer istersek
        //Main class ına gidince methdolarımız çalıştırırken parametreye oluşturduğumuz instanceleri veririz yalnızca yani methodu
        //çalıştırırken veri tipini vermemize gerke yok
        // BasketManager basketManager = new BasketManager();
        //basketManager.Add(product1);    basketManager.Add(product2);
        //Yani biz BasketManager class ının içindeki Add methdonda imzamısı nasıl attı isek o methodu çalıştırırken de o şekilde parametre vererek çalıştırırız
        //Public void Add(Product product)=>Buraya imza deniyor

        //Biz parametreye class türünden bir instance vermezsek eğer yarın öbürgün yeni bir özelliği de eklemek istersek
        //parametreye o zaman önce method da değişiklik yaparız sonra da gidip tek tek methodu çalıştırdığmız yerlerde
        //sonradan eklenen parametreyi de eklmemeiz gerekir ama biz parametreye class olarak verdiğmiz zaman metodlarımız
        //içinde o class tan isteidiğimiz özelliği önce gider product class ında property olarak ekleriz ve artık bundan sonra method da
        //parametre problememizi kalmamış olur ve sadece metod içerisinde yeni gelen property i nasıl ekleyeceksek onu ekleriz o kadar
        //bundan sonra artık tüm methodları çalıştırdığımız yerler sıkıntısız çalışır yani tek tek methodlara gidip de parametre
        //ile uğraşmamıza gerek kalmaz
       
        public void Add(Product product)//Public void Add(Product product)=>Buraya imza deniyor
        {
            Console.WriteLine("Sepete Eklendi!!!!!!"+ product.ProductId);
            Console.WriteLine("Sepete Eklendi!!!!!!" + product.ProductName);
            Console.WriteLine("Sepete Eklendi!!!!!!" + product.ProductPrice);
            Console.WriteLine("Sepete Eklendi!!!!!!" + product.ProductInfo);
            Console.WriteLine("Sepete Yeni Özellikde Eklendi!!"+ product.ProductStockNumber);

            //Gerçek bir projede bir sürü kod yazarız genelde buraya

        }
        //Bir class ın içerisinde birden fazla method olabilir

        //Program.cs demek C# dosyası olduğunu anlarız
        //Şimdi burda BasketManager class ıımızda oluşturduğumuz Add metodunu çalıştıralım nerde çalıştıracağız tabi ki
        //Program.cs de yani ana class ımızda Main methodunun içerisinde önce bu classımızdan bir instance oluştururuz
        //sonra da methodumuzu oraya çağırırız

    }
}
