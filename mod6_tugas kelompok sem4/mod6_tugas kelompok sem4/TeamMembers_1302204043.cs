using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mod6_tugas_kelompok_sem4
{
    internal class TeamMembers_1302204043
    {
        public static void ReadJson()
        {
            string fileJ = File.ReadAllText("D:/Programs/Universitas/semester 4/Praktikum_KPL/Model_2/Project_6/modul6_kelompok_sem4/Json/Muhammad_Rizky_Fajri/jurnal6_2_nim.json");

            dynamic data = JsonConvert.DeserializeObject(fileJ);

            Console.WriteLine("Team member list:");
            foreach (var item in data.members)
            {
                Console.WriteLine(item.nim + " " + item.firstName + " " + item.lastName + " " + item.age + " " + item.gender);
            }
        }
    }
}
