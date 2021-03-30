using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeTask2.UserClass
{
    public class RunTwoResuorce
    {
        public string s { get; set; }

        public void AllTwoPerformer(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {
            s = ss;
            Application.Current.Resources[resuorce] = "Ресурс 2";
            var twoPerformer = new TwoResuorce();
            twoPerformer.OnCountProcess += StartTwo_OnCountProcess;
            twoPerformer.OneWorkResurseTwo(oneTime, twoTime, threeTime, performer, ss, resuorce);
         }


 
        private void StartTwo_OnCountProcess(object sender, CountUpEvent e)
        {
            Application.Current.Resources[s] = e._resultat.ToString();
        }
    }
}
