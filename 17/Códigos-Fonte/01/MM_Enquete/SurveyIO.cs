using System;
using System.IO;

namespace Softblue
{
	/// <summary>
	/// Agrupa operações de I/O da aplicação.
	/// </summary>
	static class SurveyIO
	{
		/// <summary>
		/// Salva um objeto para um arquivo.
		/// </summary>
		/// <param name="obj">Objeto a ser salvo.</param>
		/// <param name="filePath">Arquivo de destino.</param>
		public static void SaveToFile(IStorable obj, string filePath)
		{
			FileInfo file = new FileInfo(filePath);

			using (BinaryWriter writer = new BinaryWriter(file.OpenWrite()))
			{
				obj.Save(writer);
			}
		}

		/// <summary>
		/// Carrega um objeto com dados de um arquivo.
		/// </summary>
		/// <param name="obj">Objeto a ser carregado.</param>
		/// <param name="filePath">Arquivo de origem.</param>
		public static void LoadFromFile(IStorable obj, string filePath)
		{
			FileInfo file = new FileInfo(filePath);

			using (BinaryReader reader = new BinaryReader(file.OpenRead()))
			{
				obj.Load(reader);
			}
		}
	}

	/// <summary>
	/// Interface que define os métodos de salvamento e carregamento de dados usando arquivos.
	/// </summary>
	interface IStorable
	{
		/// <summary>
		/// Grava os dados.
		/// </summary>
		/// <param name="writer">Stream de escrita.</param>
		void Save(BinaryWriter writer);

		/// <summary>
		/// Lê os dados.
		/// </summary>
		/// <param name="reader">Stream de leitura.</param>
		void Load(BinaryReader reader);
	}
}
