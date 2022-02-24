using System;

namespace VaporJogos
{
    class Program
    {
		static BibliotecaJogos biblioteca = new BibliotecaJogos();


		private static string ObterOpcaoUsuario()
		{

			Console.WriteLine("{0}{0}		Vapor Jogos {0}", Environment.NewLine);

			Console.WriteLine("	Qual operação deseja executar? {0}", Environment.NewLine);

			Console.WriteLine("1 - Listar sua biblioteca");
			Console.WriteLine("2 - Visualizar detalhes sobre um jogo");
			Console.WriteLine("3 - Instalar novo jogo");
			Console.WriteLine("4 - Atualizar jogo da sua biblioteca");
			Console.WriteLine("5 - Desinstalar jogo");
			Console.WriteLine("C - Limpar tela");
			Console.WriteLine("X - Encerar programa {0}", Environment.NewLine);


			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}


		static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						ListarJogos();
						break;
					case "2":
						VisualizarJogo();
						break;
					case "3":
						InstalarJogo();
						break;
					case "4":
						AtualizarJogo();
						break;
					case "5":
						DesinstalarJogo();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

			Console.WriteLine("{0}		Vida longa e próspera! {0}", Environment.NewLine);
			Console.ReadLine();
        }


        private static void ListarJogos()
		{
			Console.WriteLine("	Lista de jogos instalados: {0}", Environment.NewLine);

			var lista = biblioteca.Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum jogo instalado. {0}", Environment.NewLine);
				return;
			}


			foreach (var jogo in lista)
			{
                var desinstalado = jogo.retornaDesinstalado();
                
				Console.WriteLine("#ID {0}: - {1} {2}", jogo.retornaId(), jogo.retornaTitulo(), (desinstalado ? "*Desinstalado*" : ""));
			}
		}


        private static void VisualizarJogo()
		{
			Console.Write("Digite a id do jogo para visualizar mais detalhes: ");
			int indiceJogo = int.Parse(Console.ReadLine());


			var jogo = biblioteca.RetornaPorId(indiceJogo);

			Console.WriteLine("");
			Console.WriteLine("-----------------------------------------");

			Console.WriteLine(jogo);

			Console.WriteLine("-----------------------------------------");
		}


        private static void InstalarJogo()
		{
			Console.WriteLine("	Instalação de novo jogo {0}{0}", Environment.NewLine);

			Console.WriteLine("-----------------------------------------");

			Console.Write("Digite o título do jogo: ");
			string entradaTitulo = Console.ReadLine();

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			foreach (int i in Enum.GetValues(typeof(Plataforma)))
			{
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Plataforma), i));
			}
			Console.Write("{0}Digite um número dentre as opções listadas para escolha da plataforma: ", Environment.NewLine);
			int entradaPlataforma = int.Parse(Console.ReadLine());

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("{0}Digite um número dentre as opções listadas para escolha do gênero: ", Environment.NewLine);
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			foreach (int i in Enum.GetValues(typeof(Camera)))
			{
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Camera), i));
			}
			Console.Write("{0}Digite um número dentre as opções listadas para escolha do estilo de câmera: ", Environment.NewLine);
			int entradaCamera = int.Parse(Console.ReadLine());

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			foreach (int i in Enum.GetValues(typeof(ModoJogo)))
			{
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(ModoJogo), i));
			}
			Console.Write("{0}Digite um número dentre as opções listadas para escolha do modo de jogo: ", Environment.NewLine);
			int entradaModoJogo = int.Parse(Console.ReadLine());

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			Console.Write("Digite o ano de lançamento do jogo: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			Console.Write("Digite a descrição do jogo: ");
			string entradaDescricao = Console.ReadLine();

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();

			Jogo novoJogo = new Jogo(id: biblioteca.ProximoId(),
										titulo: entradaTitulo,
										plataforma: (Plataforma)entradaPlataforma,
										genero: (Genero)entradaGenero,
										camera: (Camera)entradaCamera,
										modojogo: (ModoJogo)entradaModoJogo,
										ano: entradaAno,
										descricao: entradaDescricao);

			biblioteca.Instala(novoJogo);
		}


        private static void AtualizarJogo()
		{
			Console.Write("Digite a id do jogo que deseja atualizar: ");
			int indiceJogo = int.Parse(Console.ReadLine());

			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			Console.Write("{0}Atualize o título do jogo: ", Environment.NewLine);
			string entradaTitulo = Console.ReadLine();

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			foreach (int i in Enum.GetValues(typeof(Plataforma)))
			{
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Plataforma), i));
			}
			Console.Write("Digite um número dentre as opções listadas para escolha da plataforma: ");
			int entradaPlataforma = int.Parse(Console.ReadLine());

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite um número dentre as opções listadas para escolha do gênero: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");			

			foreach (int i in Enum.GetValues(typeof(Camera)))
			{
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Camera), i));
			}
			Console.Write("{0}Digite um número dentre as opções listadas para escolha do estilo de câmera: ", Environment.NewLine);
			int entradaCamera = int.Parse(Console.ReadLine());

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			foreach (int i in Enum.GetValues(typeof(ModoJogo)))
			{
				Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(ModoJogo), i));
			}
			Console.Write("{0}Digite um número dentre as opções listadas para escolha do modo de jogo: ", Environment.NewLine);
			int entradaModoJogo = int.Parse(Console.ReadLine());

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			Console.Write("Digite o ano de lançamento do jogo: ");
			int entradaAno = int.Parse(Console.ReadLine());

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();
			Console.WriteLine("-----------------------------------------");

			Console.Write("{0}Digite a descrição do jogo: ", Environment.NewLine);
			string entradaDescricao = Console.ReadLine();

			Console.WriteLine("-----------------------------------------");
			Console.WriteLine();

			Jogo atualizaJogo = new Jogo(id: indiceJogo,
										titulo: entradaTitulo,
										plataforma: (Plataforma)entradaPlataforma, 
										genero: (Genero)entradaGenero,
										camera: (Camera)entradaCamera,
										modojogo: (ModoJogo)entradaModoJogo,
										ano: entradaAno,
										descricao: entradaDescricao);

			biblioteca.Atualiza(indiceJogo, atualizaJogo);
		}


        private static void DesinstalarJogo()
		{
			Console.Write("Digite a id do jogo que deseja desinstalar: ");
			int indiceJogo = int.Parse(Console.ReadLine());
			Console.Write("Jogo desinstalado com sucesso");
			biblioteca.Desinstala(indiceJogo);
		}
    }
}