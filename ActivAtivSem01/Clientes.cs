﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace AtivSem01
{
    public sealed class Clientes : Cadastro
    {

        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }

    }
}
