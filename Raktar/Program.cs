﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {
        static List<Termek> termekek = new List<Termek>();
        static void BeolvasRaktar()
        {
           
            StreamReader raktar = new StreamReader("raktar.csv");
            while (!raktar.EndOfStream)
            {
                /*
                 * sor[0]-> Kód
                 *  sor[1] -> Név
                 * sor[2] -> Ár
                 * sor[3] -> Darabszám
                 */
                string[] sor = raktar.ReadLine().Split(';');
                termekek.Add(new Termek(sor[0], sor[1], int.Parse(sor[2]), int.Parse(sor[3])));
             
            }
            raktar.Close();
        }
        static List<Megrendeles> megrendeltek = new List<Megrendeles>();
        static void BeolvasMegrendeles()
        {
            StreamReader megrendel = new StreamReader("rendeles.csv");
            while (!megrendel.EndOfStream)
            {
                string sor = megrendel.ReadLine();
                string[] adat= sor.Split(';');
                if (adat[0]=="M")
                {
                    megrendeltek.Add(new Megrendeles (adat[1], adat[2], adat[3]));
                }
                else
                {
                    //megrendeltek[megrendeltek.Count - 1].termekek.Add(adat);
                    megrendeltek[megrendeltek.Count - 1].TetelHozzaad(adat[2],int.Parse(adat[3]));
                }
            }
            megrendel.Close();
            
        }
        static void Main(string[] args)
        {
            BeolvasRaktar();
            BeolvasMegrendeles();
            foreach (var t in termekek)
            {
                Console.WriteLine(t.NEV);
            }
            foreach (var i in megrendeltek)
            {
                Console.WriteLine(i.DATUM +" "+i.ID+ " " + i.EMAIL);
            }
            Console.ReadKey();
        }
    }
}
