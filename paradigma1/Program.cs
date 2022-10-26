using System;


//Matnli faylda N ta talabaning familiyasi, ismi va bahosi yozilgan. Ushbu
//ma’lumotlarni to‘plamga o‘zlashtirib, 5, 4 va 3 bahoga o‘qiydigan talabalar
// soni aniqlaydigan dastur tuzing.

namespace paradigma1
{
    internal class Program
    {

        class Talaba
        {
            public string FirstName;
           public  string LastName;
           public  int Grade;

            public Talaba(string firstName, string lastName, int grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }
            }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter demanded grade (2/5):");
            int DemandGrade = Convert.ToInt32(Console.ReadLine());
            Talaba[] talabalar =
  {
                new Talaba("Oralboy", "Shamuradov", 5),
                new Talaba("Muhammadali", "Nurmuhammedov", 5),
                new Talaba("Suhrob", "Mannonov", 4),
                 new Talaba("Temurbek", "Hamroyev", 4),
                 new Talaba("Feruzbek", "Hamroyev", 2),
                 new Talaba("Nurbek", "Bazarbayev", 5),
                 new Talaba("Shermat", "Eshmatov", 3),
                 new Talaba("Vali", "Aliyev", 3),
                 new Talaba("Toshmat", "Eshmatov", 2)
        };

            for(int i = 0; i < talabalar.Length; i++)
            {
                if (talabalar[i].Grade==DemandGrade)  
                Console.WriteLine("Familiya: "+ talabalar[i].LastName+ ";   "+ "Ism: " + talabalar[i].FirstName + ";  "+ "Bahosi: " + talabalar[i].Grade + ";");
            }







        }
    }
}
