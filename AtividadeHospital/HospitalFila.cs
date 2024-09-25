using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeHospital
{
    internal class HospitalFila
    {        public Paciente[] filaPacientes = new Paciente[10];
        public int fimFila = 0;

        public void CadastrarPaciente(Paciente paciente)
        {
            if (fimFila < filaPacientes.Length)
            {
                filaPacientes[fimFila] = paciente;
                fimFila++;
                Console.WriteLine($"Paciente {paciente.Nome} cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("Fila cheia! Não é possível cadastrar mais pacientes.");
            }
        }
        public Paciente[] filaPacientes = new Paciente[10];
        public int fimFila = 0;

        public void CadastrarPaciente(Paciente paciente)
        {
            if (fimFila < filaPacientes.Length)
            {
                filaPacientes[fimFila] = paciente;
                fimFila++;
                Console.WriteLine($"Paciente {paciente.Nome} cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("Fila cheia! Não é possível cadastrar mais pacientes.");
            }
        }

        public void IncluirPacientePrioritario(Paciente paciente)
        {
            if (fimFila < filaPacientes.Length)
            {
                for (int i = fimFila; i > 0; i--)
                {
                    filaPacientes[i] = filaPacientes[i - 1];
                }
                filaPacientes[0] = paciente;
                fimFila++;
                Console.WriteLine($"Paciente prioritário {paciente.Nome} foi incluído no início da fila.");
            }
            else
            {
                Console.WriteLine("Fila cheia! Não é possível incluir mais pacientes.");
            }
        }
    }
}
    

