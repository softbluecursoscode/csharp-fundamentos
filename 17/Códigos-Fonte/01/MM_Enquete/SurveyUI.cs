using System;
using System.Collections.Generic;
using System.IO;

namespace Softblue
{
	/// <summary>
	/// Gerencia a interface gráfica da aplicação.
	/// </summary>
	class SurveyUI
	{
		/// <summary>
		/// Enquete ativa.
		/// </summary>
		private Survey survey;

		/// <summary>
		/// Arquivo associado à enquete.
		/// </summary>
		private string surveyFile;

		/// <summary>
		/// Inicia a execução da aplicação.
		/// </summary>
		public void Start()
		{
			while (true)
			{
				// Mostra o menu principal. O retorno é a opção escolhida.
				string option = ShowMainMenu();

				if (option == "1")
				{
					// Cria uma enquete e mostra o menu de enquete.
					ShowCreateMenu();
					ShowSurveyMenu();
				}
				else if (option == "2")
				{
					// Carrega uma enquete e mostra o menu de enquete.
					ShowLoadMenu();
					ShowSurveyMenu();
				}
				else if (option == "3")
				{
					// Sair da aplicação.
					return;
				}
			}
		}

		/// <summary>
		/// Mostra o menu principal.
		/// </summary>
		/// <returns>Opção escolhida.</returns>
		private string ShowMainMenu()
		{
			while (true)
			{
				Console.Clear();

				Console.WriteLine("MENU PRINCIPAL");
				Console.WriteLine("--------------\n");

				Console.WriteLine("1 - Criar uma enquete");
				Console.WriteLine("2 - Carregar uma enquate");
				Console.WriteLine("3 - Sair");
				Console.Write("O que você deseja fazer? => ");

				string option = Console.ReadLine();

				if (option != "1" && option != "2" && option != "3")
				{
					// Enquanto a opção digitada for inválida, fica no loop.
					continue;
				}

				return option;
			}
		}

		/// <summary>
		/// Mostra o menu de criar enquete.
		/// </summary>
		private void ShowCreateMenu()
		{
			survey = new Survey();
			surveyFile = null;

			Console.Clear();

			Console.WriteLine("CRIAR UMA NOVA ENQUETE");
			Console.WriteLine("----------------------\n");

			while (true)
			{
				// Solicita a pergunta da enquete.
				Console.Write("Pergunta: ");
				string question = Console.ReadLine();
				if (!String.IsNullOrEmpty(question))
				{
					survey.Question = question;
					break;
				}
			}

			int numOptions;
			while (true)
			{
				// Solicita o número de opções.
				Console.Write("Quantas opções a pergunta vai ter? ");

				try
				{
					numOptions = int.Parse(Console.ReadLine());
					break;
				}
				catch (FormatException)
				{
				}
			}

			// Solicita cada uma das opções (ID e texto).
			for (int i = 0; i < numOptions; i++)
			{
				string id;
				string text;

				while (true)
				{
					Console.Write("ID da opção {0}: ", i + 1);
					id = Console.ReadLine();
					if (!String.IsNullOrEmpty(id))
					{
						break;
					}
				}

				while (true)
				{
					Console.Write("Texto da opção {0}: ", i + 1);
					text = Console.ReadLine();
					if (!String.IsNullOrEmpty(text))
					{
						break;
					}
				}

				// Adiciona a opção à enquete.
				survey.SetOption(id, text);
			}

			// Mostra a enquete.
			Console.WriteLine("Opções adicionadas com sucesso! Veja a enquete:\n");
			Console.WriteLine(survey.GetFormattedSurvey());

			while (true)
			{
				// Solicita um arquivo para gravação da nova enquete.
				Console.Write("Digite o caminho do arquivo para salvar a enquete: ");
				string filePath = Console.ReadLine();

				if (!String.IsNullOrWhiteSpace(filePath))
				{
					try
					{
						// Salva a enquete no arquivo.
						SurveyIO.SaveToFile(survey, filePath);
						surveyFile = filePath;
						break;
					}
					catch (IOException e)
					{
						Console.WriteLine("Ocorreu um erro ao salvar o arquivo: {0}", e.Message);
					}
				}
			}

			Console.WriteLine("Enquete salva em \"{0}\". Pressione ENTER para continuar...", surveyFile);
			Console.ReadLine();
		}

		/// <summary>
		/// Mostra o menu de votação na enquete.
		/// </summary>
		private void ShowVoteMenu()
		{
			while (true)
			{
				Console.Clear();

				Console.WriteLine("VOTAR");
				Console.WriteLine("-----\n");

				Console.WriteLine("Quantidade de votos: {0}\n", survey.VoteCount);

				Console.WriteLine(survey.GetFormattedSurvey());
				Console.Write("Escolha uma opção => ");

				Option option;
				string vote;

				// Solicita o voto.
				bool valid = survey.Vote(out option, out vote);

				if (valid)
				{
					Console.Write("Obrigado pelo seu voto! Deseja continuar votando? (S/N): ");
					string yn = Console.ReadLine();

					if (yn != "S" && yn != "s")
					{
						break;
					}
				}
			}

			// Ao final da votação, salva a enquete no arquivo associado.
			SurveyIO.SaveToFile(survey, surveyFile);

			Console.Write("Fim da votação. Pressione ENTER para continuar...");
			Console.ReadLine();
		}

		/// <summary>
		/// Mostra o menu de carregamento de enquete.
		/// </summary>
		private void ShowLoadMenu()
		{
			survey = new Survey();
			
			Console.Clear();

			Console.WriteLine("CARREGAR UMA ENQUETE");
			Console.WriteLine("--------------------\n");

			while (true)
			{
				// Solicita o caminho onde a enquete está gravada.
				Console.Write("Digite o nome do arquivo da enquete: ");
				string filePath = Console.ReadLine();
				if (!String.IsNullOrEmpty(filePath))
				{

					try
					{
						// Carrega a enquete do arquivo.
						SurveyIO.LoadFromFile(survey, filePath);
						surveyFile = filePath;
						Console.Write("A enquete foi carregada com sucesso! Pressione ENTER para continuar...");
						Console.ReadLine();
						break;
					}
					catch (IOException e)
					{
						Console.WriteLine("Ocorreu um erro ao abrir o arquivo: {0}", e.Message);
					}
				}
			}
		}

		/// <summary>
		/// Mostra o menu de enquete, onde é possível votar ou ver o resultado.
		/// </summary>
		private void ShowSurveyMenu()
		{
			while (true)
			{
				Console.Clear();

				Console.WriteLine("MENU DE ENQUETE");
				Console.WriteLine("---------------\n");
				Console.WriteLine("Enquete ativa: \"{0}\"", survey.Question);
				Console.WriteLine("Número de votos: {0}\n", survey.VoteCount);

				Console.WriteLine("1 - Votar na enquete");
				Console.WriteLine("2 - Ver resultados da enquete");
				Console.WriteLine("3 - Voltar ao menu principal");
				Console.Write("Escolha uma opção => ");
				string option = Console.ReadLine();

				if (option == "1")
				{
					// Vota na enquete.
					ShowVoteMenu();
				}
				else if (option == "2")
				{
					// Mostra resultados da enquete.
					ShowSurveyResults();	
				}
				else if (option == "3")
				{
					// Volta para o menu principal.
					break;
				}
			}
		}
		
		/// <summary>
		/// Mostra o resultado da enquete.
		/// </summary>
		private void ShowSurveyResults()
		{
			Console.Clear();

			Console.WriteLine("RESULTADO DA ENQUETE");
			Console.WriteLine("--------------------\n");

			// Calcula o resultado.
			List<OptionScore> scores = survey.CalculateScores();

			Console.WriteLine("{0,-23} | {1,-5}", "Opção", "Votos");
			Console.WriteLine("-------------------------------");

			foreach (OptionScore score in scores)
			{
				Console.WriteLine("{0,-3}{1,-20} | {2,5}", score.Option.Id, score.Option.Text, score.Count);
			}

			Console.Write("\nPressione ENTER para continuar...");
			Console.ReadLine();
		}
	}
}
