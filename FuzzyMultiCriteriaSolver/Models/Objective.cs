namespace FuzzyMultiCriteriaSolver.Models
{
	/// <summary>
	/// Задача, которая решается с помощью АИИС
	/// </summary>
	public class Objective
	{
		public long Id { get; set; }

		/// <summary>
		/// Заголовок
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Описание
		/// </summary>
		public string Description { get; set; }
	}
}
