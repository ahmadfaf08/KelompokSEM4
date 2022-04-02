using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_SEM4
{
    internal class DataMahasiswa_1302200052
    {
        public class DataMahasiswa
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public string address { get; set; }
            public string courses { get; set; }
        }

        public void ReadJSON()
        {
            string file = "jurnal6_1_1302200052.json";
            string dataStr = File.ReadAllText(file);
            DataMahasiswa dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa>(dataStr);

            Console.WriteLine($"Nama depan {dataMahasiswa.firstName} nama belakang {dataMahasiswa.lastName} gender {dataMahasiswa.gender} beralamat di {dataMahasiswa.address} mengambil matkul {dataMahasiswa.courses}");
        }
    }
}
