using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kangelased
{
    class Program
    {
        static List<Kangelane> kangelased = new List<Kangelane>();

        static void LaeKangelased(string failiNimi)
        {
            string[] failiandmed = File.ReadAllLines(failiNimi);
            foreach (var item in failiandmed)
            {
                string[] nimi_ja_koht = item.Split('/');
                for (int i = 0; i < nimi_ja_koht.Length; i++)
                {
                    nimi_ja_koht[i] = nimi_ja_koht[i].Trim();
                }
                if (nimi_ja_koht[0].EndsWith("*"))
                { 
                    kangelased.Add(new SuperKangelane(nimi_ja_koht[0], nimi_ja_koht[1])); 
                }
                else
                {
                    kangelased.Add(new Kangelane(nimi_ja_koht[0], nimi_ja_koht[1]));
                }
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
