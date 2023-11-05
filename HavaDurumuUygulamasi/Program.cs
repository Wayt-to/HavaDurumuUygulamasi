using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HavaDurumuUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. ÖDEV Canlı Hava Durumu

            //Eskişehir İstanbul Ankara arası seçim ile canlı havadurumu



            string apikey = "e4b7070abab1899610fd58316c8d4c53";

            Console.Write("1)Eskişehir\n2)İstanbul\n3)İzmir\n4)Trabzon\nHangi Şehirin Hava Durumunu Öğrenmek İstersiniz ? : ");

            string giris = Console.ReadLine();

            if (giris == "1")
            {
                string linkesk = "https://api.openweathermap.org/data/2.5/weather?q=Eskişehir&lang=tr&units=metric&mode=xml&appid=" + apikey;
                XDocument havadurumu = XDocument.Load(linkesk);
                string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
                string nem = havadurumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
                string yuzde = havadurumu.Descendants("humidity").ElementAt(0).Attribute("unit").Value;

                Console.WriteLine("| Eskişehir için sıcaklık : " + havasicaklik + " C°" + "\n| Hava Durumu : " + durum + "\n| Nem oranı : " + yuzde + nem);

            }
            if (giris == "2")
            {
                string linkist = "https://api.openweathermap.org/data/2.5/weather?q=İstanbul&lang=tr&units=metric&mode=xml&appid=" + apikey;
                XDocument havadurumu = XDocument.Load(linkist);
                string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
                string nem = havadurumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
                string yuzde = havadurumu.Descendants("humidity").ElementAt(0).Attribute("unit").Value;
                Console.WriteLine("| İstanbul için sıcaklık : " + havasicaklik + " C°" + "\n| Hava Durumu : " + durum + "\n| Nem oranı : " + yuzde + nem);
            }
            if (giris == "3")
            {
                string linkizmir = "https://api.openweathermap.org/data/2.5/weather?q=İzmir&lang=tr&units=metric&mode=xml&appid=" + apikey;
                XDocument havadurumu = XDocument.Load(linkizmir);
                string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
                string nem = havadurumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
                string yuzde = havadurumu.Descendants("humidity").ElementAt(0).Attribute("unit").Value;
                Console.WriteLine("| İzmir için sıcaklık : " + havasicaklik + " C°" + "\n| Hava Durumu : " + durum + "\n| Nem oranı : " + yuzde + nem);

            }
            if (giris == "4")
            {
                string linktrb = "https://api.openweathermap.org/data/2.5/weather?q=Trabzon&lang=tr&units=metric&mode=xml&appid=" + apikey;
                XDocument havadurumu = XDocument.Load(linktrb);
                string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
                string nem = havadurumu.Descendants("humidity").ElementAt(0).Attribute("value").Value;
                string yuzde = havadurumu.Descendants("humidity").ElementAt(0).Attribute("unit").Value;
                Console.WriteLine("| Trabzon için sıcaklık : " + havasicaklik + " C°" + "\n| Hava Durumu : " + durum + "\n| Nem oranı : " + yuzde + nem);

            }




            #endregion
        }
    }
}
