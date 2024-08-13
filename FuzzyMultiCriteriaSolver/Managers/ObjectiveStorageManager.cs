using FuzzyMultiCriteriaSolver.Models;
using FuzzyMultiCriteriaSolver.Util;
using Microsoft.EntityFrameworkCore;

namespace FuzzyMultiCriteriaSolver.Managers
{
	public class ObjectiveStorageManager : IObjectivesStorageManager
	{
		private CriteriaSolverContext _context;

		public ObjectiveStorageManager(CriteriaSolverContext context)
		{
			_context = context;
		}

		public async Task<bool> DeleteObjective(long id)
		{
			_context.Objectives.Remove(await _context.Objectives.FindAsync(id));
			await _context.SaveChangesAsync();
			return true;
		}

		public async Task<IEnumerable<Objective>> GetAll()
		{
			return await _context.Objectives.ToListAsync();
		}

		public async Task<Objective> GetObjective(long id)
		{
			return await _context.Objectives.FindAsync(id);
		}

		public async Task<Objective> SaveObjective(Objective objective)
		{
			await _context.AddAsync(objective);
			await _context.SaveChangesAsync();
			return objective;
		}

		public async Task<Objective> UpdateObjective(Objective objective)
		{
			_context.Objectives.Update(objective);
			await _context.SaveChangesAsync();
			return objective;
		}
	}
}
