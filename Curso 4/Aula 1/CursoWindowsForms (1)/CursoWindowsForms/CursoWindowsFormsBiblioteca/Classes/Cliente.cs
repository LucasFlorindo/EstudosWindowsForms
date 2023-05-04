﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Classes
{
    class Cliente
    {
        public class Unit
        {
            //cadastral
            public string Id { get; set; }
            public string Nome { get; set; }
            public string NomePai { get; set; }
            public string NomeMae { get; set; }
            public bool TemPai { get; set; }
            public string CPF { get; set; }
            public int Genero { get; set; }

            //endereço
            public string CEP { get; set; }
            public string Logradouro { get; set; }
            public string Complemento { get; set; }
            public string Bairro { get; set; }
            public string Cidade { get; set; }
            public string Estado { get; set; }

            //dados
            public string Telefone { get; set; }
            public string Profissao { get; set; }
            public double RendaFamiliar { get; set; }
        }

        public class List
        {
            public List<Unit> ListUnite { get; set; }
        }
    }
}
