namespace FuzzyMultiCriteriaSolver.Models
{
	/// <summary>
	/// Запрос пользователя к нейронке
	/// </summary>
	public class UserRequest
	{
		public long Id { get; set; }

		/// <summary>
		/// К какому инстансу идет запрос
		/// </summary>
		public ANFISInstance AnfisInstance { get; set; }
		public long AnfisInstanceId { get; set; }

		/// <summary>
		/// Ответ от нейросети
		/// </summary>
		public decimal Score { get; set; }
	}
}
