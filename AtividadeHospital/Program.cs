using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeHospital
{
    internal class Program 
    {
        static Paciente ColetarInformacoesPaciente()
        {
            Console.Write("Digite o nome completo do paciente:");
            string nome = Console.ReadLine();

            Console.Write("Digite o endereço do paciente:");
            string endereco = Console.ReadLine();

            Console.Write("Digite o RG ou CPF do paciente:");
            string rgCpf = Console.ReadLine();

            return newPaciente(nome, endereco, rgCpf);
        }
        
            static void Main(string[] args)
        {
            HospitalFila hospitalFila = new HospitalFila();
            char opcao;

            do
            {
                Console.WriteLine("\nOpções:");
                Console.WriteLine("1.Cadastrar Paciente");
                Console.WriteLine("2.incluir paciente prioritário");
                Console.WriteLine("3.Listar fila de pacientes");
                Console.WriteLine("4.Atender paciente");
                Console.WriteLine("q.Sair");
                Console.WriteLine("Escolha uma opção:");
                opcao = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (opcao)
                {
                    case '1':
                        Paciente pacienteNormal = ColetarInformacoesPaciente();

                        hospitalFila.CadastrarPaciente(pacienteNormal);
                        break;
                    case '2':
                        Paciente pacientePrioritario = ColetarInformacoesPaciente();
                        hospitalFila.IncluirPacientePrioritario(pacientePrioritario);
                        break;
                    case '3':
                        hospitalFila.ListarFila();
                        break;
                    case '4':
                        hospitalFila.AtenderPaciente();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 'q');
        }
    }
}
