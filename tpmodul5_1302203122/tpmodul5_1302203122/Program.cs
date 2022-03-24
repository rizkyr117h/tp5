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
            SayaTubeVidio a = new SayaTubeVidio("Tutorial Design By Contract – Rizky Ramdhan Nugraha");
            a.printVideoDetails();
        }
    }
    class SayaTubeVidio
    {
        int id;
        string title;
        int playCount;

        public SayaTubeVidio(string judul)
        {
            title = judul;
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

    }



}
