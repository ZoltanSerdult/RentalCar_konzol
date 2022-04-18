using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar_konzol
{
    class Kolcsonzes
    {
        readonly int id;
        DateTime tol;
        DateTime ig;

        public int Id => id;

        public DateTime Tol { get => tol; set => tol = value; }
        public DateTime Ig { get => ig; set => ig = value; }

        public Kolcsonzes(int id, DateTime tol, DateTime ig)
        {
            this.id = id;
            Tol = tol;
            Ig = ig;
        }
    }
}
