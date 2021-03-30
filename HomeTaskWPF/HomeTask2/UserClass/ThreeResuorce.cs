using System;
using System.Threading;
using System.Windows;

namespace HomeTask2.UserClass
{
    public class ThreeResuorce : EventClass
    {
        private void CountUpThree(int one, int two, int three, int performer, string ss, string resuorce)
        {
            string dd;
            RunOneResuorce runOneResuorce = new RunOneResuorce();
            try
            {
                int i = 0;
                int sec = three;
                while (i != three)
                {
                    dd = "занят исполнителем " + performer.ToString() + "    " + sec.ToString() + "сек.";
                    Application.Current.Resources[ss] = dd;
                    Thread.Sleep(1000);
                    sec--;
                    i++;
                }
            }
#pragma warning disable CS0168
            catch (Exception e)
            {
#pragma warning disable SYSLIB0006
                thread.Abort();
            }
            dd = "свободен";
            Application.Current.Resources[ss] = dd;
            Thread.Sleep(1000);
            if (!ExitClass.exit)
            {
                runOneResuorce.AllOnePerformer(one, two, three, performer, ss, resuorce);
            }
        }

        private Thread thread = null;

        public void OneWorkResuorceThree(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {
            thread = new Thread(new ParameterizedThreadStart((obj) => CountUpThree(oneTime, twoTime, threeTime, performer, ss, resuorce)));
            thread.IsBackground = true;
            thread.Start();
        }

    }
}
