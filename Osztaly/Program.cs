using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Osztaly
{
    class Program
    {
        static void Main(string[] args)

        {
            List<Kutyak> dogs = new List<Kutyak>();

            FileStream fs = new FileStream("dogs.db", FileMode.OpenOrCreate);

            Kutyak.reader = new BinaryReader(fs);


            //Kutyak dog1 = new Kutyak("Vizsla", "Dió", 3);
            //Kutyak dog2 = new Kutyak("Puli", "Maszat", 5);
            //Kutyak dog3 = new Kutyak("Kuvasz", "Bogi", 8);


            while (fs.Length > fs.Position)
            {
                dogs.Add(new Kutyak());
            }


            //Kutyak dog1 = new Kutyak();
            //Kutyak dog2 = new Kutyak();
            //Kutyak dog3 = new Kutyak();

            fs.Close();

            foreach (Kutyak dog in dogs)
            {
                Console.WriteLine($"{dog.GetFajta()}, {dog.GetName()}, {dog.GetAge()}");

            }

          

            FileStream fs1 = new FileStream("dogs.db", FileMode.OpenOrCreate);

            Kutyak.writer = new BinaryWriter(fs1);

            foreach (Kutyak dog in dogs)
            {
                dog.SavetoFile();
            }


            //dog1.SavetoFile();
            //dog2.SavetoFile();
            //dog3.SavetoFile();

            fs1.Close();

            Console.ReadKey();
            
        }
    }
}
