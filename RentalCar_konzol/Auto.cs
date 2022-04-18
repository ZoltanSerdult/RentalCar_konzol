using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar_konzol
{
    class Auto
    {
        readonly int id;
        string rendszam;
        string marka;
        string model;
        double ar;

        public int Id => id;

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public double Ar { get => ar; set => ar = value; }

        public Auto(int id, string rendszam, string marka, string model, double ar)
        {
            this.id = id;
            Rendszam = rendszam;
            Marka = marka;
            Model = model;
            Ar = ar;
        }
    }
}
