using FuzzyMultiCriteriaSolver.Models;
using FuzzyMultiCriteriaSolver.Models.DTO;

namespace FuzzyMultiCriteriaSolver.Managers
{
	public interface IVariableStorageManager
	{
		Task<Variable> AddVariable(VariableSaveDTO variable);
		Task<Variable> UpdateVariable(Variable variable);
		Task<bool> DeleteVariable(long id);
		Task<IEnumerable<Variable>> GetObjectiveVariables(long objectiveId);
		Task<Variable> GetVariable(long id);
	}
}
