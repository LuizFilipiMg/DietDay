﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   
    public abstract class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Ddd { get; set; }
        public string Senha { get; set; }
        public string Documento { get; set; }
        public  Int16 TipoDocumento { get; set; }
        public DateTime DataHora { get; set; }
        public bool Ativo { get; set; }
        public Int16 Sexo { get; set; }   

    }
}
