using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.IO;

namespace mod6_tugas_kelompok_sem4
{
    internal class TeamMembers_1302200037
    {
        public static void ReadJSON()
        {
           public TeamMember[] members { get; set; }

        public void ReadJSON()
        {
            string fileName = "jurnal6_2_1302200037.json";

            string jsonString = File.ReadAllText(fileName);
            TeamMembers_1302200037 jsonData = JsonSerializer.Deserialize<TeamMembers_1302200037>(jsonString);

            this.members = jsonData.members;

            this.info();
        }

        public void info()
        {
            Console.WriteLine("Team member list:");
            foreach (var team in members)
            {
                team.info();
            }
        }
    }

    class TeamMember
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }

        public void info()
        {
            Console.WriteLine(this.nim + " " + this.firstName + " " + this.lastName + " (" + this.age + " " + this.gender + ")");
        }
    }
}