using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class DortIslem//Toplama,çıkarma,çarpma,bölme işlemi yapan bir sınıf gibi düşünelim
        //Yani toplama methodu, çıkarma methodu, çarpma methodu, bölme methodu yazacağız
        //Bir matematik projesinde birden fazla yerde kullanılacaklarıı düşünelim

    {

        //Method oluştururken parametre olma sebebi şudur ki biz her seferinde aynı sayıları toplayacak değiliz bu method farklı
        //farklı sayıları toplarken de kullanılabilsin yani kullanıcı hangi sayıları toplamak isterse o sayıları toplasın dediğmiz
        //için aynı sepette her ürünün üstünde sepete ekle var yani her ürün kendine özeldir kendine ait id si vardır ve her ürünün
        //üstündeki sepete ekle o ürünü ekler yani her sepete ekle butonu farklı bir ürünü eklemeye yarıyor onun  için parametre
        //bizim o methodu farklı ürünler için veya o methodu farklı sayılar için de kullanabilmemizi daha doğrusu o methodu neye
        //göre yaptı isek o işlemi biz amaca göre yaptığımız o hedef için her yerde kullanabilelim diye paremetre kouyarız bu
        //kısım çok önemli mutlaka mantığını kavaramamız gerekiyor
        //Parametreler her seferinde farklı olacaktır biz bu methodu aynı mantıkta farklı yerlerde farklı ihtiyaçlara kullacağiımız
        //için method çalıştırılırken her seferinde farklı farklı parametrelerle kullanılmak istenecektir
        public void Topla(int sayi1, int sayi2)//Toplama yapabilmek için iki sayıya ihtiyacım var. Bu methodu çağırabilmek için
                                               //iki tane sayi vermemiz gerkiuor demekktir bu imzada
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine( "Sonuç: "+toplam );//Burda string ile başladığı için toplam olan int türünü de string gibi düşünüyor
        }


    }
}
