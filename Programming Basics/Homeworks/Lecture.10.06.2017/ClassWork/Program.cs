using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hasEighteen = true;
            bool isInHomeTown = true;

            bool canVote = hasEighteen && isInHomeTown;
            bool canVote1 = 1 > 3 && 5 < 3;

            bool iphoneCharged = true;
            bool androidCharger = false;
            bool canUsePhone = iphoneCharged || androidCharger;

        }
    }
}
