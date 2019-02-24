using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Countryside a = new Countryside();
            a.Data();
        }
    }
    class Countryside
    {
        public void Data()
        {
            Village Alst = new Village("Alst", false);
            Village Schvenig = new Village("Schvenig", false);
            Village Maeland = new Village("Maeland", false);
            Village Helmholtz = new Village("Helmholtz", false);
            Village Wessig = new Village("Wesig", false);
            Village Uster = new Village("Uster", true);
            Village Badden = new Village("Badden", false);

            Alst.westVillage = Schvenig;
            Alst.DistanceTravelled = 14;

            Schvenig.westVillage = Maeland;
            Schvenig.DistanceTravelled = 9;

            Maeland.westVillage = Schvenig;
            Maeland.DistanceTravelled = 9;

            Schvenig.westVillage = Helmholtz;
            Schvenig.DistanceTravelled = 28;

            Helmholtz.westVillage = Schvenig;
            Helmholtz.DistanceTravelled = 28;

            Schvenig.westVillage = Alst;
            Schvenig.DistanceTravelled = 14;

            Alst.eastVillage = Wessig;
            Alst.DistanceTravelled = 19;

            Wessig.eastVillage = Badden;
            Wessig.DistanceTravelled = 11;

            Badden.eastVillage = Wessig;
            Badden.DistanceTravelled = 11;

            Wessig.eastVillage = Uster;
            Wessig.DistanceTravelled = 28;

            Uster.eastVillage = Wessig;
            Uster.DistanceTravelled = 28;

            Wessig.eastVillage = Alst;
            Wessig.DistanceTravelled = 19;

        }

    }
    public class Village
    {
        Village Alst;
        Village Schvenig;
        Village Maeland;
        Village Helmholtz;
        Village Wessig;
        Village Uster;
        Village Badden;

        public Village westVillage;
        public Village eastVillage;
        public int DistanceTravelled;
        public string AstrildeVillage;
        public bool isHere;
        public Village(string VillageName, bool AstrildeLocation)
        {
            AstrildeVillage = VillageName;
            isHere = AstrildeLocation;
            if(isHere == true)
            {
                Console.WriteLine("Astrilde is here");
                Console.WriteLine("Astrild is in {0}", VillageName);
            }
        }
    }
}
