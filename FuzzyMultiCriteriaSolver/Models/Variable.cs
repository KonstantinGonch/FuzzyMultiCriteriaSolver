namespace FuzzyMultiCriteriaSolver.Models
{
	/// <summary>
	/// Описание переменной из набора данных
	/// </summary>
	public class Variable
	{
		public long Id { get; set; }

		/// <summary>
		/// Связанная задача
		/// </summary>
		public Objective Objective { get; set; }
		public long? ObjectiveId { get; set; }

		/// <summary>
		/// Название
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Четкая переменная или нет
		/// </summary>
		public bool IsStrict { get; set; }
	}
}
