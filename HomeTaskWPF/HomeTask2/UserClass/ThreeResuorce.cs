using System;
using System.Threading;

namespace HomeTask2.UserClass
{
    public class ThreeResuorce : EventClass
    {
        
        public void CountUpThree(int one, int two, int three, int performer, string ss, string resuorce)
        {
            bool f = false;
            string dd;
            RunOneResuorce runOneResuorce = new RunOneResuorce();
            try
            {
                int i = 0;
                int sec = three;
                while (i != three)
                {
                    dd = "занят исполнителем " + performer.ToString() + "    " + sec.ToString() + "сек.";
                    Process(dd);

                    f = true;
                    Thread.Sleep(1000);
                    sec--;
                    i++;
                }

                f = false;
            }
            catch (Exception e)
            {
                thread.Abort();
            }
            dd = "свободен";
            Process(dd);
            Thread.Sleep(1000);
            if (!ExitClass.exit)
            {
                runOneResuorce.AllOnePerformer(one, two, three, performer, ss, resuorce);

            }

        }

        private Thread thread = null;

        public void OneWorkResurseThree(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {

            thread = new Thread(new ParameterizedThreadStart((obj) => CountUpThree(oneTime, twoTime, threeTime, performer, ss, resuorce)));
            thread.IsBackground = true;

            thread.Start();
        }

    }
}
