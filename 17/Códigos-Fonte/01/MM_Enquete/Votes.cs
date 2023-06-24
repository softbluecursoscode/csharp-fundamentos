using System;
using System.Collections.Generic;
using System.IO;

namespace Softblue
{
	/// <summary>
	/// Enquete.
	/// </summary>
	partial class Survey
	{
		/// <summary>
		/// Votos de uma enquete. Implementa IStorable.
		/// </summary>
		private class Votes : IStorable
		{
			/// <summary>
			/// Enquete associada.
			/// </summary>
			private Survey survey;

			/// <summary>
			/// Dicionário que mapeia uma opção da enquete para um número de votos.
			/// </summary>
			private Dictionary<Option, int> votes = new Dictionary<Option, int>();

			/// <summary>
			/// Contador de votos da enquete.
			/// </summary>
			public int VoteCount { get; private set; }

			/// <summary>
			/// Construtor.
			/// </summary>
			/// <param name="survey">Enquete associada.</param>
			public Votes(Survey survey)
			{
				this.survey = survey;
			}

			/// <summary>
			/// Adiciona um voto à enquete.
			/// </summary>
			/// <param name="option">Opção votada.</param>
			public void AddVote(Option option)
			{
				int count;
				if (votes.TryGetValue(option, out count))
				{
					// Se o opção já teve algum voto, incrementa o número de votos.
					count++;
					votes[option] = count;
				}
				else
				{
					// Se a opção ainda não havia sido votada, considera 1 voto.
					votes[option] = 1;
				}

				// Incrementa o número total de votos da enquete.
				VoteCount++;
			}

			/// <summary>
			/// Calcula os votos da enquete.
			/// </summary>
			/// <param name="sort">Indica se deve haver ordenação por ordem decrescente de votos. O padrão é true.</param>
			/// <returns>Lista de objetos OptionScore, representando os votos em cada uma das opções.</returns>
			public List<OptionScore> CalculateScores(bool sort = true)
			{
				List<OptionScore> scores = new List<OptionScore>();

				foreach (KeyValuePair<Option, int> entry in votes)
				{
					scores.Add(new OptionScore(entry.Key, entry.Value));
				}

				if (sort)
				{
					// Ordena a lista se for necessário.
					scores.Sort();
				}

				return scores;
			}

			/// <see cref="SurveyIO.Save()"/>
			public void Save(BinaryWriter writer)
			{
				// Grava o tamanho do dicionário
				writer.Write(votes.Count);

				foreach (KeyValuePair<Option, int> entry in votes)
				{
					// Grava cada um dos elementos do dicionário: a opção e depois o número de votos.
					Option option = entry.Key;
					int numVotes = entry.Value;

					// Chama o Save() de Option para gravar a opção.
					option.Save(writer);

					writer.Write(numVotes);
				}
			}

			/// <see cref="SurveyIO.Load()"/>
			public void Load(BinaryReader reader)
			{
				// Lê o tamanho do dicionário
				int count = reader.ReadInt32();

				// Itera criando as opções e seus respectivos votos.
				for (int i = 0; i < count; i++)
				{
					Option option = new Option();

					// Chama o Load() de Option para ler a opção.
					option.Load(reader);

					int numVotes = reader.ReadInt32();

					// Acumula o número total de votos
					VoteCount += numVotes;

					votes.Add(option, numVotes);
				}
			}
		}
	}
}
