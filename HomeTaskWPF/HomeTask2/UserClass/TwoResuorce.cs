using System;
using System.Threading;


namespace HomeTask2.UserClass
{

    public class TwoResuorce : EventClass
    {
       public void CountUpTwo(int one, int two, int three, int performer, string ss, string resuorce)
        {
            bool f = false;
            string dd;
            RunThreeResuorce runThreeResuorce = new RunThreeResuorce();
            try
            {
                int i = 0;
                int sec = two;
                while (i != two)
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
            finally
            {
                dd = "свободен";
                Process(dd);
                Thread.Sleep(1000);
                if (!ExitClass.exit)
                {
                    runThreeResuorce.AllTwoPerformer(one, two, three, performer, ss, resuorce);
                }

            }
        }

        private Thread thread = null;

        public void OneWorkResurseTwo(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {
            thread = new Thread(new ParameterizedThreadStart((obj) => CountUpTwo(oneTime, twoTime, threeTime, performer, ss, resuorce)));
            thread.IsBackground = true;
            thread.Start();
        }

    }
}
