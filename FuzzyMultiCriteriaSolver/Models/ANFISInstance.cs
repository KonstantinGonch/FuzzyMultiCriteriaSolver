namespace FuzzyMultiCriteriaSolver.Models
{
	/// <summary>
	/// Инстанс ANFIS
	/// </summary>
	public class ANFISInstance
	{
		public long Id { get; set; }

		/// <summary>
		/// Ссылка на PMML-модель
		/// </summary>
		public string PmmlRef { get; set; }

		/// <summary>
		/// Ссылка на задачу
		/// </summary>
		public Objective Objective { get; set; }
		public long ObjectiveId { get; set; }

		/// <summary>
		/// Средняя квадратичная ошибка
		/// </summary>
		public decimal MSE { get; set; }

		/// <summary>
		/// Путь к датасету
		/// </summary>
		public string DatasetPath { get; set; }
	}
}
