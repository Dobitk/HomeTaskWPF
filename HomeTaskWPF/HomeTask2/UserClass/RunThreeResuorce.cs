using System;
using System.Windows;

namespace HomeTask2.UserClass
{
    public class RunThreeResuorce 
    {
        public string s { get; set; }

        public void AllTwoPerformer(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {
            s = ss;
            Application.Current.Resources[resuorce] = "Ресурс 3";
            var threePerformer = new ThreeResuorce();
            threePerformer.OnCountProcess += StartThree_OnCountProcess;
            threePerformer.OneWorkResurseThree(oneTime, twoTime, threeTime, performer, ss, resuorce);
        }

         private void StartThree_OnCountProcess(object sender, CountUpEvent e)
        {
            Application.Current.Resources[s] = e._resultat.ToString();
        }
    }
}
