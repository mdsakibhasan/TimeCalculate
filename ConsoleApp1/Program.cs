using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bill = 0;

            DateTime startTime = DateTime.Now;
            DateTime endTime = DateTime.Now.AddHours(0.7);
            DateTime timeNow = startTime;
            DateTime lastendtime = startTime;
            DateTime forshow;


            Console.WriteLine("Start Date Time : "+startTime);
            Console.WriteLine("End Date Time   : " + endTime);
            Console.WriteLine("\r\n");

            while (timeNow <= endTime)
            {
                forshow = timeNow.AddMinutes(20);
                decimal rate = ((timeNow.Hour >= 9 && timeNow.Hour >= 23) && (timeNow.Hour <= 24 && timeNow.Hour >= 8)) ? Convert.ToDecimal(0.30) : Convert.ToDecimal(0.20);
                bill = bill + rate;
                Console.WriteLine("Time: {0:HH:mm} to {1:HH:mm}, rate: {2:#,0.00} paisa", timeNow, forshow, rate);
                lastendtime = timeNow;
                timeNow = timeNow.AddMinutes(20);
            }
            Console.WriteLine("\r\n");
            Console.WriteLine("Bill: {0:HH:mm} to {1:HH:mm}, {2:#,0} mins, Taka {3:#,0.00}", startTime, endTime, (endTime - startTime).TotalMinutes, bill);

            Console.ReadLine();

        }
    }
}
