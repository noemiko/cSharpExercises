using System;

namespace test
{
    class Program
    {
       
        static void Main(string[] args)
        {    //define time to wake up
            DateTime time = DateTime.Now.AddMilliseconds(5000);
            Console.WriteLine("input: "+time);
            //turn on alarm
            Alarm budzik = new Alarm(time);

            Console.ReadLine();
        }


    }
}
