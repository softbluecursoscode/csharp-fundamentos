using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Softblue
{
	/// <summary>
	/// Enquete.
	/// </summary>
	partial class Survey : IStorable
	{
		/// <summary>
		/// Dicionário que mapeia um ID de opção para uma opção.
		/// </summary>
		private IDictionary<string, Option> options = new Dictionary<string, Option>();
		
		/// <summary>
		/// Referencia objeto responsável por calcular os votos.
		/// </summary>
		private Votes votes;
		
		/// <summary>
		/// Questão da enquete.
		/// </summary>
		public string Question { get; set; }

		/// <summary>
		/// Contador de votos da enquete.
		/// </summary>
		public int VoteCount
		{
			get
			{
				// Delega a chamada para VoteCount do objeto Votes.
				return votes.VoteCount;
			}
		}

		/// <summary>
		/// Construtor.
		/// </summary>
		public Survey()
		{
			// Instancia o objeto que calcula os votos.
			votes = new Votes(this);
		}

		/// <summary>
		/// Adiciona ou altera uma opção da enquete. Se o ID ainda não existe, adiciona; senão altera.
		/// </summary>
		/// <param name="id">ID da opção.</param>
		/// <param name="text">Texto da opção.</param>
		public void SetOption(string id, string text)
		{
			// Cria a opção, convertendo o ID para maiúsculo.
			Option option = new Option();
			option.Id = id.ToUpper();
			option.Text = text;

			if (!options.ContainsKey(id))
			{
				// Adiciona se o ID não existe.
				options.Add(id, option);
			}
			else
			{
				// Altera se o ID já existe.
				options[id] = option;
			}
		}

		/// <summary>
		/// Retorna a enquete em um formato de string.
		/// </summary>
		/// <returns>Enquete formatada.</returns>
		public string GetFormattedSurvey()
		{
			// Usa um StringBuilder para evitar concatenações de strings.
			StringBuilder sb = new StringBuilder();

			sb.AppendLine(Question);

			foreach (Option option in options.Values)
			{
				sb.Append(option.Id).Append(" - ").AppendLine(option.Text);
			}

			return sb.ToString();
		}

		/// <summary>
		/// Vota na enquete, através da digitação da opção no console.
		/// </summary>
		/// <param name="option">Receberá o objeto Option associado ao voto.</param>
		/// <param name="vote">Receberá o voto dado pelo usuário.</param>
		/// <returns>true se o voto foi em uma opção válida; false, caso contrário.</returns>
		public bool Vote(out Option option, out string vote)
		{
			// Lê o voto.
			vote = Console.ReadLine();
			
			// Converte o voto para maisúculo.
			vote = vote.ToUpper();
			
			// Busca o objeto no dicionário.
			bool valid = options.TryGetValue(vote, out option);

			if (valid)
			{
				// Caso tenha encontrado, computa o voto.
				votes.AddVote(option);
			}

			return valid;
		}

		/// <summary>
		/// Calcula os votos da enquete.
		/// </summary>
		/// <param name="sort">Indica se o resultado deve ser ordenado em ordem decrescente de número de votos (o padrão é true).</param>
		/// <returns>Lista de objetos OptionScore representando os votos.</returns>
		public List<OptionScore> CalculateScores(bool sort = true)
		{
			// Delega o cálculo para o objeto Votes.
			return votes.CalculateScores(sort);
		}

		/// <see cref="SurveyIO.Save()"/>
		public void Save(BinaryWriter writer)
		{
			// Salva a questão, o número de opções e depois cada uma das opções.
			writer.Write(Question);
			writer.Write(options.Count);

			foreach (Option option in options.Values)
			{
				// Chama o Save() de Option para salvar a opção.
				option.Save(writer);
			}

			// Salva os votos da enquete.
			votes.Save(writer);
		}

		/// <see cref="SurveyIO.Load()"/>
		public void Load(BinaryReader reader)
		{
			// Carrega a questão da enquete e depois cada uma das opções.
			Question = reader.ReadString();

			options = new Dictionary<string, Option>();
			int count = reader.ReadInt32();

			for (int i = 0; i < count; i++)
			{
				Option option = new Option();

				// Chama o Load() de Option para ler a opção.
				option.Load(reader);

				options[option.Id] = option;
			}

			// Carrega os votos da enquete.
			votes.Load(reader);
		}
	}
}
