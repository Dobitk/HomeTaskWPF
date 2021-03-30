using System;
using System.Windows;

namespace HomeTask2.UserClass
{
    public class RunThreeResuorce : ThreeResuorce
    {
        public string s { get; set; }

        public void AllTwoPerformer(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {
            s = ss;
            Application.Current.Resources[resuorce] = "Ресурс 3";
            OneWorkResuorceThree(oneTime, twoTime, threeTime, performer, ss, resuorce);
        }

    }
}
