using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace test
{

    class Alarm
    {
        private DateTime time;
        private static Timer aTimer;
        public Alarm(DateTime time)
        {
            this.time = time;
            aTimer = new Timer(100);
            aTimer.Elapsed += new ElapsedEventHandler(WakeUpOnTime);
            aTimer.Enabled = true;
        }
        //method to inform user when it's time to wake up
        private void WakeUpOnTime(object source, ElapsedEventArgs e)
        {
            if (e.SignalTime.Second == this.time.Second)
            {
                Console.WriteLine(e.SignalTime +": budzik");
            }
           
        }
    }
}
