using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Pahalane:Kangelane
    {
        public Pahalane(string nimi, string asukoht):base(nimi,  asukoht)
        {

        }

        public override int Päästa(int ohustatuid)
        {
            return 0;
        }

        public override string ToString()
        {
            return Nimi + " ohustab " + Asukoht;
        }
    }
}
