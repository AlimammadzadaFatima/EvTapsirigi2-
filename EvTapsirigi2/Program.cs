using System;

namespace EvTapsirigi2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tapsirig1


            //1. Daxil edilmis string deyerinin icinde reqem olub olmadigini tapan proqram

            //Console.WriteLine("yazi daxil edin :");
            //string yazi = Console.ReadLine();
            //char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            //bool sert = false;
            //for (int i = 0; i < yazi.Length; i++)
            //{
            //    for (int n = 0; n < numbers.Length; n++)
            //    {

            //        if (yazi[i] == numbers[n])
            //        {
            //            sert = true;
            //        }
            //    }
            //}
            //if (sert == true)
            //{ Console.WriteLine("var"); }
            //else

            //{ Console.WriteLine("yoxdur"); }
            #endregion
            #region tapdirig2

            //2. Daxil edilmis string deyerinde ardicil
            //a ve l charlarinin olub olmadigini tapan proqram.
            //Misalcun alma, salam ve s. kimi sozlerde "vardir" yazdirmalidir geriye.
            //Console.WriteLine("yazi daxil edin :");
            //string yazi = Console.ReadLine();
            //bool sert = false;
            //for (int i = 0; i < yazi.Length; i++)
            //{ if (yazi[i]=='a'&& yazi[i+1]=='l')
            //    { sert = true;
            //        break;
            //    }
            //}
            //if (sert == true)
            //{ Console.WriteLine("var"); }
            //else
            //{ Console.WriteLine("yoxdur"); }
            #endregion
            #region tapsirig3
            //3.Verilmis dedin reqemlerinin ededi ortasini tapan proqram
            int number = 678;
            int sum = 0;
            int counter = 0;
            while (number > 0)
            { var sum1 = number % 10;
                number = (number - sum1) / 10;
                counter++;
                sum += sum1;
            }
                if (counter>0)
            { Console.WriteLine( "ededin ededi ortasi :" +sum/counter); }
            #endregion
                //
        }
    }
}







