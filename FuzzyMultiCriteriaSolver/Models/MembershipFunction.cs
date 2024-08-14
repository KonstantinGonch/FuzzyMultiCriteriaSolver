using FuzzyMultiCriteriaSolver.Models.Enums;

namespace FuzzyMultiCriteriaSolver.Models
{
	/// <summary>
	/// Функция принадлежности переменной
	/// </summary>
	public class MembershipFunction
	{
		public long Id { get; set; }

		/// <summary>
		/// Ссылка на переменную
		/// </summary>
		public Variable Variable { get; set; }
		public long VariableId { get; set; }

		/// <summary>
		/// Тип функции принадлежности
		/// </summary>
		public MembershipFunctionType MembershipFunctionType { get; set; }

		//TODO: Не норм
		/// <summary>
		/// Аргументы для конструктора функции из либы
		/// </summary>
		public string Arguments { get; set; }
	}
}
