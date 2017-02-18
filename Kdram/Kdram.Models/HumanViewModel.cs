﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kdram.Models
{
    public class HumanViewModel
    {
        public int Isn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Idcard { get; set; }
        public string Soccard { get; set; }
        public string Descript { get; set; }
        public DateTime Creationdate { get; set; }
        public DateTime Lastmodificationdate { get; set; }
    }
}
