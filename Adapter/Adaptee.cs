﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Método Specific Request de Adaptee invocado.");
        }
    }
}
