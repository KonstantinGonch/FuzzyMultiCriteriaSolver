namespace FuzzyMultiCriteriaSolver.Models.DTO
{
	public class AnfisDTO
	{
		public bool HasPmml { get; set; }
		public decimal MSE { get; set; }
		public bool DatasetLoaded { get; set; }
		public IEnumerable<GraphicalReportDTO> Graphics { get; set; }
	}
}
