using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_SEM4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa_1302200052 d = new DataMahasiswa_1302200052();
            d.ReadJSON();
            Console.WriteLine();
            TeamMembers_1302200052 s = new TeamMembers_1302200052();
            s.ReadJSON();
        }
    }
}