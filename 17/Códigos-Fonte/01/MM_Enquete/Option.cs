using System;
using System.IO;

namespace Softblue
{
	/// <summary>
	/// Opção de uma enquete.
	/// </summary>
	class Option : IStorable, IEquatable<Option>
	{
		/// <summary>
		/// ID da opção (o que deve ser digitado para escolher a opção).
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// Texto associado à opção.
		/// </summary>
		public string Text { get; set; }

		/// <see cref="SurveyIO.Save()"/>
		public void Save(BinaryWriter writer)
		{
			writer.Write(Id);
			writer.Write(Text);
		}

		/// <see cref="SurveyIO.Load()"/>
		public void Load(BinaryReader reader)
		{
			Id = reader.ReadString();
			Text = reader.ReadString();
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Option);
		}

		public bool Equals(Option other)
		{
			if (other == null)
			{
				return false;
			}

			return this.Id == other.Id;
		}

		public override int GetHashCode()
		{
			return Id.GetHashCode();
		}
	}
}
