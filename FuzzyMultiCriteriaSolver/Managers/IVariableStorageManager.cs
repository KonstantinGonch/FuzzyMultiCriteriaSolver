using FuzzyMultiCriteriaSolver.Models;

namespace FuzzyMultiCriteriaSolver.Managers
{
	public interface IVariableStorageManager
	{
		Task<Variable> AddVariable(Variable variable);
		Task<Variable> UpdateVariable(Variable variable);
		Task<bool> DeleteVariable(long id);
		Task<IEnumerable<Variable>> GetObjectiveVariables(long objectiveId);
		Task<Variable> GetVariable(long id);
	}
}
