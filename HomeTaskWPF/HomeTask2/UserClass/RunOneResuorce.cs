using System;
using System.Windows;

namespace HomeTask2.UserClass
{
    public class RunOneResuorce : OneResuorce, IStartClass
    {
 
 
        public string s { get; set; }
        public void AllOnePerformer(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {
            s = ss;
            Application.Current.Resources[resuorce] = "Ресурс 1";
            OneWorkResuorce(oneTime, twoTime, threeTime, performer, ss, resuorce);
        }

    }
}
