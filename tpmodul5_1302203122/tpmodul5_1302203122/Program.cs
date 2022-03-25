using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302203122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaTubeVidio a = new SayaTubeVidio("Tutorial Design By Contract – Rizky Ramdhan.");
                Console.WriteLine("Massukan angka : ");
                int b = Convert.ToInt32(Console.ReadLine());
                a.increasePlayCount(b);
                a.printVideoDetails();
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        class SayaTubeVidio
        {
            int id;
            string title;
            int playCount;

            public SayaTubeVidio(string judul)
            {
                if (judul != null && judul.Length < 100)
                {
                    title = judul;
                }

                Random randm = new Random();
                id = randm.Next(10000, 99999);
                playCount = 0;
            }
            public void printVideoDetails()
            {
                Console.WriteLine("Title : " + title);
                Console.WriteLine("id : " + id);
                Console.WriteLine("playCount : " + playCount);
            }

            public void increasePlayCount(int data)
            {
                if (data < 10000001)
                {
                    playCount = playCount + data;
                }

            }
        }
    }



}
