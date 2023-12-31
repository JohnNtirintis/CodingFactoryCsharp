﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShallowDeepCopyApp.Model
{
    internal class Address
    {
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? Zipcode { get; set; }

        public override string? ToString()
        {
            return $"Street: {Street}, Number: {Number}, Zipcode: {Zipcode}";
        }
    }
}
