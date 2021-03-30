using HomeTask2.UserClass;
using System;
using System.Threading;


namespace HomeTask2.UserClass
{

    public class OneResuorce : EventClass
    {
       public void CountUp(int one, int two,int three , int performer, string ss, string resuorce)
        {
            bool f = false;
            string dd;
            RunTwoResuorce runTwoResuorce = new RunTwoResuorce();
            try
            {
                int i = 0;
                int sec = one;
                
                while (i != one)
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
                  runTwoResuorce.AllTwoPerformer(one, two, three, performer, ss, resuorce);

              }
            }
        }

        private Thread thread = null;

        public  void OneWorkResurse(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {
            thread = new Thread(new ParameterizedThreadStart((obj) => CountUp(oneTime, twoTime, threeTime, performer, ss, resuorce)));
            thread.IsBackground = true;
            thread.Start();
      
        }

    }



}
