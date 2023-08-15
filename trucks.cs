using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referenece__william
{
     class trucks : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double Weight { get; }

        public trucks(double speedParam, double weightParam, string licenseNum)
        {
            Wheels = 4;
            Speed = speedParam;
            LicensePlate = "gctc-21";
            Weight = weightParam;
            LicensePlate = licenseNum;

            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public void Stringify()
        {
          Console.WriteLine($"The truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }

        public void IncreasseSpeed()
        {
            Speed += 5;
        }
        public void DecreasseSpeed()
        {
            Speed -= 5;
        }
    }
}
