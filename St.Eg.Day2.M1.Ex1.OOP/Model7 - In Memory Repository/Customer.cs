﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace St.Eg.M1.Ex1.OOP.Model7
{
    public class Customer : EntityBase
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
    }
}
