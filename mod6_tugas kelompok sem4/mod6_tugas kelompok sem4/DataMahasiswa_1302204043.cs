using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace mod6_tugas_kelompok_sem4
{
    internal class DataMahasiswa_1302204043
    {
        public static void ReadJson()
        {
            string fileJ = File.ReadAllText("D:/Programs/Universitas/semester 4/Praktikum_KPL/Model_2/Project_6/modul6_kelompok_sem4/Json/Muhammad_Rizky_Fajri/jurnal6_1_nim.json");

            dynamic mhs = JsonConvert.DeserializeObject(fileJ);

            Console.WriteLine("Nama: \t\t" + mhs.firstName + mhs.lastName);
            Console.WriteLine("Gender: \t" + mhs.gender);
            Console.WriteLine("Age: \t\t" + mhs.age);
            Console.WriteLine("Alamat: \t" + mhs.address.streetAddress);
            Console.WriteLine("City: \t\t" + mhs.address.city);
            Console.WriteLine("State: \t\t" + mhs.address.state);
            //Console.WriteLine("Courses:\t\t" + mhs.courses.code);

            foreach (var item in mhs.courses)
            {
                Console.WriteLine(item.code + " - " + item.name);
            }

        }
    }
}
