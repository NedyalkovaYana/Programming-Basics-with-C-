using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniCamp
{
    class Program
    {
        static void Main()
        {
            int groups = int.Parse(Console.ReadLine());
            double sumAllPeople = 0;
            double sumPeopleInGroups = 0;
            double presentCar = 0;
            double presetMicrobus = 0;
            double presentLittelBus = 0;
            double presentBigBus = 0;
            double presentTrain = 0;
            double sumPeopleInCar = 0;
            double sumPeopleInMicrobus = 0;
            double sumPeopleInLittelBus = 0;
            double sumPeopleInBigBus = 0;
            double sumPeopleInTrain = 0;

            for (int i = 0; i < groups; i++)
            {
                int numberPeopleInGroup = int.Parse(Console.ReadLine());
                sumAllPeople += numberPeopleInGroup;
                if (numberPeopleInGroup <=5) //lek avtomobil
                {
                    sumPeopleInCar += numberPeopleInGroup;
                }
                else if (numberPeopleInGroup >=6 && numberPeopleInGroup <=12) //mikrobus
                {
                    sumPeopleInMicrobus += numberPeopleInGroup;
                    
                }
                else if (numberPeopleInGroup >= 13 && numberPeopleInGroup <= 25) //maluk avtobus
                {
                    sumPeopleInLittelBus += numberPeopleInGroup;
                   
                }
                else if (numberPeopleInGroup >=26 && numberPeopleInGroup <= 40) //bigBus
                {
                    sumPeopleInBigBus += numberPeopleInGroup;
                   
                }
                else if (numberPeopleInGroup >=41) //train
                {
                    sumPeopleInTrain += numberPeopleInGroup;
                    
                }
            }
            presentCar = sumPeopleInCar / sumAllPeople * 100;
            Console.WriteLine("{0:f2}%", presentCar);
            presetMicrobus = sumPeopleInMicrobus / sumAllPeople * 100;
            Console.WriteLine("{0:f2}%", presetMicrobus);
            presentLittelBus = sumPeopleInLittelBus / sumAllPeople * 100;
            Console.WriteLine("{0:f2}%", presentLittelBus);
            presentBigBus = sumPeopleInBigBus / sumAllPeople * 100;
            Console.WriteLine("{0:f2}%", presentBigBus);
            presentTrain = sumPeopleInTrain / sumAllPeople * 100;
            Console.WriteLine("{0:f2}%", presentTrain);

        }
    }
}
