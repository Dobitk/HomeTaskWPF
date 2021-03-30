using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeTask2.UserClass
{
    public class RunTwoResuorce : TwoResuorce
    {
        public string s { get; set; }

        public void AllTwoPerformer(int oneTime, int twoTime, int threeTime, int performer, string ss, string resuorce)
        {
            s = ss;
            Application.Current.Resources[resuorce] = "Ресурс 2";
            OneWorkResuorceTwo(oneTime, twoTime, threeTime, performer, ss, resuorce);
        }

    }
}
