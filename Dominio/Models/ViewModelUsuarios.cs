﻿using Dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Models
{
    public class ViewModelUsuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }
        public string Senha { get; set; }
        public string Documento { get; set; }
        public EnumTipoDocumento TipoDocumento { get; set; }

    }
}
