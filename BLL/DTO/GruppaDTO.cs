using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class GruppaDTO
    {
        public string name { get; set; }
        public string curator { get; set; }
        //public int starosta { get; set; }
        public string education { get; set; }
        public string cathedra { get; set; }
        public string year { get; set; }
        public string educLevel { get; set; }
        public string educDegreeDTO { get; set; }
    }
}
