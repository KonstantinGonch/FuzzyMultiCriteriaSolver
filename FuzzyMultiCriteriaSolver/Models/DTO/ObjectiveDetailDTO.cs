namespace FuzzyMultiCriteriaSolver.Models.DTO
{
	public class ObjectiveDetailDTO
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public IEnumerable<VariableDTO> Variables { get; set; }
		public IEnumerable<MembershipFunctionDTO> MembershipFunctions { get; set; }
		public ANFISInstance AnfisInstance { get; set; }
	}
}
