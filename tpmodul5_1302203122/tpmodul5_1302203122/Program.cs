using System;
using System.Diagnostics;
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

                SayaTubeVidio a = new SayaTubeVidio("Tutorial Design By Contract – Rizky Ramdhan.");
                Console.WriteLine("Massukan angka : ");
                int b = Convert.ToInt32(Console.ReadLine());
                a.increasePlayCount(b);
                a.printVideoDetails();

                SayaTubeVidio c = new SayaTubeVidio("Tutorial Design By Contract – Rizky Ramdhan.");
                
                for (int i = 0; i < 215; i++)
                {
                    c.increasePlayCount(100000000);
                }

                c.printVideoDetails();

        }
        class SayaTubeVidio
        {
            int id;
            string title;
            int playCount;

            public SayaTubeVidio(string judul)
            {
                Debug.Assert(judul != null, "title tidak boleh kosong");
                Debug.Assert(judul.Length < 100, "title kepanjangan");

                string test;

                try
                {
                    test = checked(judul);
                    title = judul;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Random randm = new Random();
                id = randm.Next(0, 100000);
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
                Debug.Assert(this.playCount <= int.MaxValue);
                Debug.Assert(data <= 10000000, "Input tidak boleh lebih dari 10 juta");

                int test;
                try
                {
                    test = checked(this.playCount + data);
                    this.playCount += data;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error : " + ex.Message);
                    this.playCount = this.playCount;
                }

            }
        }
    }



}
