﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte ExamResult = Convert.ToByte(Console.ReadLine());
            //if (ExamResult > 0 && ExamResult < 100)
            //{

            //    if (ExamResult > 0 && ExamResult < 40)
            //    {
            //        Console.WriteLine(" F  imatahandan kesildiniz");
            //    }
            //    else if (ExamResult > 40 && ExamResult < 50)
            //    {
            //        Console.WriteLine(" D  imatahandan kecdiniz");
            //    }
            //    else if (ExamResult > 50 && ExamResult < 60)
            //    {
            //        Console.WriteLine(" C  imatahandan kecdiniz");
            //    }
            //    else if (ExamResult > 60 && ExamResult < 80)
            //    {
            //        Console.WriteLine(" B  imatahandan kecdiniz");
            //    }
            //}
            //else if (ExamResult > 80 && ExamResult < 100)
            //{
            //    Console.WriteLine(" A  imatahandan kecdiniz");
            //}
            ////else
            ////{
            ////    Console.WriteLine(" imatahandan neticesi duzgun deyil");
            ////}





            //for (int i = 0; i <= 100; i++)
            //{
            //    float reqem3 = i % 3;
            //    float reqem7 = i % 7;
            //    if (reqem7 == 0 && reqem3 == 0)
            //    {
            //        Console.WriteLine(i + " - her ikisine  bolunur");
            //    }
            //    else if (reqem7 == 0)
            //    {
            //        Console.WriteLine(i + " - 7 e bolunur");

            //    }
            //    else if (reqem3 == 0)
            //    {
            //        Console.WriteLine(i + " - 3 e bolunur");

            //    }

            //}




            double price = 0;
            double newprice = 0;
            double faiz = 0;
            Console.WriteLine("evvelki qiymeti daxil et");
     
            string line = Console.ReadLine();

            while (!double.TryParse(line, out price))
            {
                Console.WriteLine("duzgun reqem daxil edin");
                line = Console.ReadLine();

            }
            Console.WriteLine("son qiymeti daxil et");
            string line1 = Console.ReadLine();
            while (!double.TryParse(line1, out newprice))

            {
               
                Console.WriteLine("duzgun reqem daxil edin");
                line1 = Console.ReadLine();

            }
            faiz = ((newprice - price) / 100)%100;
            if (price < newprice)
            {
                Console.WriteLine("artim  var");
            }
            else if (price > newprice)
            {
                Console.WriteLine("artim  yoxdu");
            }



            Console.ReadLine();



        }

    }
}




