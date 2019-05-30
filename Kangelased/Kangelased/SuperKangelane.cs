using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class SuperKangelane:Kangelane
    {
        private double _Osavus;

        public SuperKangelane(string nimi, string asukoht):base(nimi,asukoht)
        {
            _Osavus = SingleRandom.Instance.Next(1, 60)/10.0;
        }

        public override int Päästa(int inimesteArv)
        {
            return (int)Math.Round((95+_Osavus)/100 * inimesteArv,0);
        }

        public override string ToString()
        {
            return base.ToString() + " ja ta on selles " + _Osavus + " protsenti parem kui lihtsalt kangelased";
        }
    }
}
