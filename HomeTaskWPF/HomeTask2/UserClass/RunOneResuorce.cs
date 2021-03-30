using System;
using System.Windows;

namespace HomeTask2.UserClass
{
    public class RunOneResuorce : StartClass
    {
 
 
        public string s { get; set; }
        public void AllOnePerformer(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {
            s = ss;
            Application.Current.Resources[resuorce] = "Ресурс 1";
            var onePerformer = new OneResuorce();
            onePerformer.OnCountProcess += StartOne_OnCountProcess;
            onePerformer.OneWorkResurse(oneTime, twoTime, threeTime, performer, ss, resuorce);
        }


        private void StartOne_OnCountProcess(object sender, CountUpEvent e)
        {

            Application.Current.Resources[s] = e._resultat.ToString();
        }

    }
}
