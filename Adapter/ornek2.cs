/*Adaptör: özetle mevcut bir sınıfı veya arayüz sınıfını, eldeki farklı bir arayüz sınıfına uygun hale getirerek tekrar kullanmak amacıyla uygulanır.

  Adapter tasarım deseni Structural (Yapısal) bir tasarım deseni 
  Adapter tasarım deseninde 4 temel yapı vardır.Bunlar ;
      1- Adaptee : Mevcut sisteme uydurulmak istenen nesne. 
      2- Adapter: Mevcut sisteme uydurma işlemini yapan nesne. 
      3- Target: İstemcinin ihtiyaç duyduğu interface.
      4- Client: İşlemleri gerçekleştirdiğimiz ortak sınıf. İstemci , uygulama. 


-Karşılıklı savaş yapılabilecek bir oyun tasarlayacağız.
    Oyunumuzda kullanacağımız düşmanlar genelde araçlardan oluşmaktadır ve düşmanların tahmini
    metodları interface'imizde tanımlanmıştır.
 
 */

#region Main
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Design_Pattern___Adapter_App
{
    class Program
    {
        public class Client
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Düşman tankı");
                Console.WriteLine();
 
                DusmanTankı x11 = new DusmanTankı();
                x11.Silah();
                x11.SurucuIsmi("Reha");
                x11.AracSurusHızı();
 
                Console.WriteLine();
                Console.WriteLine("Robot");
                Console.WriteLine();
 
                DusmanRobotu robot216 = new DusmanRobotu();
                robot216.Yumruk();
                robot216.KontrolEden("Baha");
                robot216.Yurume();
                 
 
                Console.WriteLine();
                Console.WriteLine("Düşman Robotu");
                Console.WriteLine();
 
                // Robotumuzu bu şekilde tanımlıyoruz ve yeni robotumuzun da türü IDusman.
 
                IDusman dusman = new DusmanRobotuAdapter(robot216);
                 
                dusman.Silah();
                dusman.SurucuIsmi("Esra");
                dusman.AracSurusHızı();
                 
 
 
                Console.ReadLine();
 
            }
 
        }
 
    }
#endregion


    public interface IDusman  // Target
    {
        void Silah();                        // Aracın üstünde bulunan herhangi bir silah
        void AracSurusHızı();                // Aracın hızı
        void SurucuIsmi(string isim);        // Aracı kullanan kişinin ismi
    }
 
    public class DusmanTankı : IDusman  //  örnek
    {
        Random randomSayi = new Random();
 
        public void Silah()
        {
            int silahHasari = randomSayi.Next(20) + 1;
            string hasar = Convert.ToString(silahHasari);
            Console.WriteLine("Tank  " + hasar + " hasar vermiştir.");
 
        }
 
        public void AracSurusHızı()
        {
            int arachizi = randomSayi.Next(40) + 1;
            string hiz = Convert.ToString(arachizi);
            Console.WriteLine("Tank  " + hiz + " km " + " hizla gitmektedir.");
 
        }
 
        public void SurucuIsmi(string isim)
        {
            Console.WriteLine("Tankı " + isim + " kullanmaktadır.");
 
        }
 
 
    }
 
 
    //  Tankımız tamamlandı.Tanımladığımız tank oyunumuzda istediğimiz şekilde çalışıyor.
    //  Ancak oyunumuza ilerleyen zamanlarda bir robot eklemek istedik ve robot tankın kullandığı
    //  metodlardan farklı işlevlere sahip.Ancak ekleyeceğimiz yeni robot da aynı zamanda
    //  bir düşman.Yani yine Dusman interface'ini kullanmak istiyoruz.İşte bu noktada
    //  Structural (Yapısal) bir tasarım deseni olan "Adapter" i kullanıyoruz.
    //  İlk olarak robotumuzu "DusmanRobot" adında bir class tanımlıyıoruz.Tanımladığımız classda da
    //  ihtiyacımız olan metodları tanımlıyoruz.
 
 
    public class DusmanRobotu  // Adaptee
    {
        Random randomSayi = new Random();
 
        public void Yumruk()
        {
            int yumrumHasari = randomSayi.Next(40) + 1;
            string hasar = Convert.ToString(yumrumHasari);
            Console.WriteLine("Robot yumruk atarak  " + hasar + " hasar vermiştir.");
 
        }
 
        public void Yurume()
        {
            int robothizi = randomSayi.Next(20) + 1;
            string hiz = Convert.ToString(robothizi);
            Console.WriteLine("Robotun hizi  " + hiz + " km'dir.");
        }
 
        public void KontrolEden(string kullanici)
        {
            Console.WriteLine("Robot  " + kullanici + " tarafından yönetilmektedir.");
        }
 
         
 
    };
 
    // Şimdi ise en önemli kısım olan Adapter imizi tanımlama kısmındayız.
 
    public class DusmanRobotuAdapter : IDusman  // Adapter
    {
 
        DusmanRobotu robot;
 
        // İlk olarak Constructor metod yazılır.Bunun nedeni ise yeni yaratacağımız robotun IDusmandan 
        // türünde olmasını istiyor olmamızdır.
 
        public DusmanRobotuAdapter(DusmanRobotu yeniRobot)
        {
            robot = yeniRobot;
        }
 
        public void Silah()
        {
            robot.Yumruk();
        }
 
        public void AracSurusHızı()
        {
            robot.Yurume();
        }
 
        public void SurucuIsmi(string isim)
        {
            robot.KontrolEden(isim);
        }
 
        
    }
}




