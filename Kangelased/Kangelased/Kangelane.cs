using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangelased
{
    class Kangelane
    {
        private string _Nimi;
        private string _Asukoht;
        public string Nimi { get => _Nimi; set => _Nimi = value; }
        public string Asukoht { get => _Asukoht; set => _Asukoht = value; }

        public Kangelane(string kangelaseNimi, string kangelaseAsukoht)
        {
            Nimi = kangelaseNimi;
            Asukoht = kangelaseAsukoht;
        }

        public int Päästa(int inimesteArv)
        {
            double a = Math.Round((inimesteArv * 0.95),0);
            return (int)a;
        }

        public override string ToString()
        {
            return $"{Nimi} kaitseb {Asukoht}";
        }
    }
}
