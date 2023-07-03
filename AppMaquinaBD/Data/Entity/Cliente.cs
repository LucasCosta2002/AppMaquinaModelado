﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMaquinaBD.Data.Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string CUIL { get; set; } = "";
    }
}
