using FuzzyMultiCriteriaSolver.Models;
using FuzzyMultiCriteriaSolver.Util;
using Microsoft.EntityFrameworkCore;

namespace FuzzyMultiCriteriaSolver.Managers
{
	public class VariableStorageManager : IVariableStorageManager
	{
		private CriteriaSolverContext _context;

		public VariableStorageManager(CriteriaSolverContext ctx)
		{
			_context = ctx;
		}

		public async Task<Variable> AddVariable(Variable variable)
		{
			await _context.Variables.AddAsync(variable);
			await _context.SaveChangesAsync();
			return variable;
		}

		public async Task<bool> DeleteVariable(long id)
		{
			_context.Variables.Remove(await _context.Variables.FindAsync(id));
			await _context.SaveChangesAsync();
			return true;
		}

		public async Task<IEnumerable<Variable>> GetObjectiveVariables(long objectiveId)
		{
			return await _context.Variables.Where(e => e.ObjectiveId == objectiveId).ToListAsync();
		}

		public async Task<Variable> GetVariable(long id)
		{
			return await _context.Variables.FindAsync(id);
		}

		public async Task<Variable> UpdateVariable(Variable variable)
		{
			_context.Variables.Update(variable);
			await _context.SaveChangesAsync();
			return variable;
		}
	}
}
