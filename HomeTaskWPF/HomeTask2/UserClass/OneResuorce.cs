using HomeTask2.UserClass;
using System;
using System.Threading;
using System.Windows;


namespace HomeTask2.UserClass
{
    public class OneResuorce
    {
       private void CountUp(int one, int two,int three , int performer, string ss, string resuorce)
        {
            string dd;
            RunTwoResuorce runTwoResuorce = new RunTwoResuorce();
            try
            {
                int i = 0;
                int sec = one;
                
                while (i != one)
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
            finally
            {
              dd = "свободен";
              Application.Current.Resources[ss] = dd;
                Thread.Sleep(1000);
              if (!ExitClass.exit)
              {
                  runTwoResuorce.AllTwoPerformer(one, two, three, performer, ss, resuorce);
              }
            }
        }

        private Thread thread = null;

        public  void OneWorkResuorce(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {
            thread = new Thread(new ParameterizedThreadStart((obj) => CountUp(oneTime, twoTime, threeTime, performer, ss, resuorce)));
            thread.IsBackground = true;
            thread.Start();
        }
    }



}
