
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    //Biz class larımızı 2 şey için kullanıyoruz 1 prop eklemek için 2, operasyon yani method eklemek için
    //prop yazarsak gerisini kendi getiriyor buna snippet deniyor
    //Biz ürün denildiğinde bir üründe bizim standartlarımıza göre hangi özellikler olması gerekiyorsa onları ekleriz
    //Class bizim için birbirinden farklı veri tiplerini aynı yerde bizim için tutabilen ve o veri türünün farklı instancelerini
    //veya nesnelerini çoğaltabilen bir yapıdır yani biz dizi de tutmak istesek dizi de sadece aynı tür verileri tutabiliyoruz
    //ama class da ise biz ürünün kendisini tutuyoruz ve o üründen üretilen tüm farklı çeşitler işte o class tan ortaya çıkıyor
    //ve verilerimizi çok kolay yönetebiliyoruz dışardan sonradan değişiklik taleplerini sistemimize çok kolay adapte edebiliyoruz
    //hiç bir kodumuza dokunmadan
    //ONEMLI!!!!!!
    //Adım1-Bir class oluştururuz. Adım2-O üründe olması gereken özellikleri belirleriz ve oraya property olarak onları tiplerine göre ekleriz
    //Adım3-Bu class üzerinden o ürünümüzden kaç farklı instance veya nesne oluşturarak o ürünün bilgilerini gireriz ki bu verileri
    //normalde bir veri kaynağından yani veri tabanından gelecek
    //Adım4-Oluşturduğmuz instanceleri, yani nessneleri ürün class ımızdan oluşturduğumuz nesne değişkenlerimizi oluşturduğmuz
    //Product classımızın bir arrayini oluşturarak onun içerisine class ımızdan oluşturduğmuz instancelerimizi yani nesnelerimiz
    //atarak onları listeleriz ve artık biz burda elimizdeki tüm ürünlerimizin özelliklerine ulaşabiliiriz
   
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public double ProductPrice { get; set; }
        public string ProductInfo { get; set; }
       
        //Sonradan özellik eklememiz gerktiğini varsayalım
        public int ProductStockNumber { get; set; }
    }
}
