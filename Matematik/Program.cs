using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            //Şuna dikkat herzaaman bir class içindeki methdou çalıştırmak için önce o class tan bir instance veya bir nesne oluştur
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(12,8);
            Console.WriteLine("------------------------------");
            dortIslem.Topla(24, 12);
            Console.WriteLine("---------------------------------");
            dortIslem.Topla(34, 56);
            Console.WriteLine("-------------------------------------");
            dortIslem.Topla(12, 8);


            Console.ReadLine();

        }
    }
}
