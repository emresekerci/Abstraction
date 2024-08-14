using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Sirket
    {
        public  string Ad { get; set; }
        public  string Soyad { get; set; }
        public  string Departman { get; set; }
        public abstract void Gorev();
        
            
        
    }
    public class YazilimGelistirici : Sirket
    {
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin Yazılım Geliştiricisi, yazılım geliştiriyorum.");
        }
    }

    // Proje Yöneticisi sınıfı
    public class ProjeYoneticisi : Sirket
    {
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin Proje Yöneticisi, proje yönetiyorum.");
        }
    }

    // Satış Temsilcisi sınıfı
    public class SatisTemsilcisi : Sirket
    {
        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad} şirketin Satış Temsilcisi, satış yapıyorum.");
        }
    }
}
