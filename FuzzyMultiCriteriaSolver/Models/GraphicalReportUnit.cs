namespace FuzzyMultiCriteriaSolver.Models
{
	/// <summary>
	/// Граф отчет об обучении ANFIS
	/// </summary>
	public class GraphicalReportUnit
	{
		public long Id { get; set; }

		/// <summary>
		/// Заголовок
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Ссылка на инстанс ANFIS
		/// </summary>
		public ANFISInstance AnfisInstance { get; set; }
		public long AnfisInstanceId { get; set; }

		/// <summary>
		/// Ссылка на файл
		/// </summary>
		public string FileRef { get; set; }
	}
}
