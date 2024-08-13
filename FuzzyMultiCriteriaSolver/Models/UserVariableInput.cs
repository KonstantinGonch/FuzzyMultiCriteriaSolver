namespace FuzzyMultiCriteriaSolver.Models
{
	/// <summary>
	/// Значение переменной из задачи для передачи в обученную ANFIS
	/// </summary>
	public class UserVariableInput
	{
		public long Id { get; set; }

		/// <summary>
		/// Ссылка на переменную
		/// </summary>
		public Variable Variable { get; set; }
		public long? VariableId { get; set; }

		/// <summary>
		/// Введенное значение
		/// </summary>
		public decimal? Value { get; set; }

		/// <summary>
		/// К какому пользовательскому запросу относится
		/// </summary>
		public UserRequest UserRequest { get; set; }
		public long UserRequestId { get; set; }
	}
}
