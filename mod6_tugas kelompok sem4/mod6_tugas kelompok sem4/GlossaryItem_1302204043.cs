using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mod6_tugas_kelompok_sem4
{
    public class Glossary
    {
        public Glossary() { }
        public string? title { get; set; }
        public GlossDiv? GlossDiv { get; set; }
    }
    public class GlossDiv
    {
        public GlossDiv() { }   
        public string? title { get; set; }
        public GlossList? GlossList { get; set; }
    }
    public class GlossList
    {
        public GlossList() { }  
        public GlossEntry? GlossEntry { get; set; }
    }
    public class GlossEntry
    {
        public GlossEntry() { }
        public string? ID { get; set; }
        public string? SortAs { get; set; }
        public string? GlossTerm { get; set; }
        public string? Acronym { get; set; }
        public string? Abbrev { get; set; }
        public List<GlossDef>? GlossDef { get; set; }
        public string? GlossSee { get; set; }
    }
    public class GlossDef
    {
        public GlossDef() { }
        public string? para { get; set; }
        public List<string>? GlossSeeAlso { get; set; }
    }
    public class GlossaryItem
    {
        public GlossaryItem() { }
        public Glossary? glossary { get; set; }
    }

    public class GlossaryItem_1302204043
    {
        public GlossaryItem_1302204043() { }
        public static void ReadJson()
        {
            
            string fileJ = File.ReadAllText("D:/Programs/Universitas/semester 4/Praktikum_KPL/Model_2/Project_6/modul6_kelompok_sem4/Json/Muhammad_Rizky_Fajri/jurnal6_3_nim.json");
            
            var data = JsonConvert.DeserializeObject <GlossaryItem>(fileJ);

            Console.WriteLine("Gloss Entry :\n");
            //Console.WriteLine("ID :\t\t" + data.title);
            //Console.WriteLine("SortAs :\t\t" + data.SortAs);
            Console.WriteLine(data);


        }
    }
}
