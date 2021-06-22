using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummer1 = 10;
            int nummer2 = 30;
            nummer1 = nummer2;
            nummer2 = 65;
            Console.WriteLine("nummer1= "+nummer1);
            //ValueTypes-Değer Tipler
            //Sayısal veri tipleri- int,decimal,double,float,bool bunlar değer tiplerdir
            //Bellekte değer tipler Stack adlı alanda tutuluyor tamamen herşey burda tanımlanıyor ve değer tutuyor
            //Değer tipler de mesela sayi1=sayi2 denildği zaman sayi1 sadece sayi2 nin değerini kopyalar değerini alır ve
            //sayi2 ile irtibatı kalmaz sonrasında yani sadece onun değeri ile ilgileniyor onun dışında başka hiçbir işi yok

            int[] nummrer1 = new int[] { 10, 20, 30 };
            int[] nummrer2 = new int[] { 100, 200, 300 };
            nummrer1 = nummrer2; //Referanse
            nummrer2[0] = 900;
            //nummrer1[0]=?
            Console.WriteLine("Nummrer1[0]= "+ nummrer1[0] );
            //Reference Types-Referans Tipler
            //Array,class,interface bunlar ise referans tiplerdir
            //Bellekte Stack ve Heap diye bir sistem var biz herhangib bir referans tip oluşturduğumuz zaman değişken olan nummrer1 stack da tanımlanırken
            //ona atanan nummrer1=new int[]{10,20,30} ile biz diyoruz ki bellekteki Heap kısmında yeni bir alan oluştur yeni bir adres
            //oluştur ve değerleri oraya yaz demiş oluyoruz ve o da mesela 101 numaralı adreste nummrer1 i tutar
            //daha sonra int nummrer2=new int[]{100,200,300} dediğimiz zaman yine nummrer2 yi stack kısmında tanımlar
            //ve newledğimiz anda da yine bellekteki heap kısmında nummrer2 için bir alan açar, bir adres oluşturur
            //mesela 102 no lu adres oluşturur oraya yazar
            //Biz nummrer1 array değişkenine nummrer2 array değişkenini atadığmız zaman ise nummrer1 değişkenine demiş oluyorz
            //ki sen git nummrer2 nin adresini tut artık diyoruz ve o nummrer2 nin adresini tutmaya başlıyor ve
            //bundan sonra nummrer2 de olan tüm değişikliler nummrer1 değişkeni de aynı adresi tuttuğu için nummrerr1 e de
            //değişiklikler yansımış oluyor
            //Pekii nummer1 in önceki tuttuğu adres ne oluyor o adres de belli bir süre sonra garbage collector tarafından silinecektir
            Console.ReadLine();
            //
        }
    }
}
