using System;
//10 Litseylar haqida ma’lumotlar berilgan (class Lyceums). Olinpiadada 3 yil
//ichida g‘o lib bo‘lgan Litseyni qidirib topuvchi dastur tuzing.

namespace Paradigma2
{
    public class Lyceum
    {
        public string LyceumsName;
        public string Adresss;
        public int CountStudent;
        public int Awards;
        public Lyceum(string lyceumsName, string adresss, int countStudent, int awards)
        {
            LyceumsName = lyceumsName;
            Adresss = adresss;
            CountStudent = countStudent;
            Awards = awards;
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {

            Lyceum[] Lyceums =
            {
                new Lyceum("al-Xorazmiy;  ","Istiqlol street;  ",400,5),
            
                new Lyceum("TATU;  ","Oybek street;  ",450,2),

                new Lyceum("WEST;  ","Magrur street;  ",500,4),

                new Lyceum("UWED;  ","Mustaqillik street;  ",200,6),

                new Lyceum("TSUL;  ","Markaz street;  ",350,3)


            };

            Console.WriteLine(Lyceums.);
        }
    }
}
