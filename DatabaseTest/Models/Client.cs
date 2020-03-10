﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace DatabaseTest.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public byte[] Picture { get; set; }

        public string Gender { get; set; }
    }
}