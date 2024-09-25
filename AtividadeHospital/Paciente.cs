using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeHospital
{
    internal class Paciente
    {        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string RgCpf { get; set; }

        public Paciente(string nome, string endereco, string rgCpf)
        {
            Nome = nome;
            Endereco = endereco;
            RgCpf = rgCpf;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Endereço: {Endereco}, RG/CPF: {RgCpf}";
        }
    }
    
}

    

