using FuzzyMultiCriteriaSolver.Models;
using FuzzyMultiCriteriaSolver.Models.DTO;
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

		public async Task<ObjectiveDetailDTO> GetObjectiveDetails(long id)
		{
			var res = await (from obj in _context.Objectives.Where(e => e.Id == id)
					  join variable in _context.Variables on obj.Id equals variable.ObjectiveId
					  join anfis in _context.AnfisInstances on obj.Id equals anfis.ObjectiveId
					  join mFunc in _context.MembershipFunctions on variable.Id equals mFunc.VariableId
					  join graphs in _context.GraphicalReportUnits on anfis.Id equals graphs.AnfisInstanceId
						select new
						{
							ObjectiveId = obj.Id,
							ObjectiveTitle = obj.Title,
							VariableTitle = variable.Title,
							VariableIsStrict = variable.IsStrict,
							MFuncType = mFunc.MembershipFunctionType,
							MFuncArgs = mFunc.Arguments,
							GraphsRef = graphs.FileRef,
							GraphsTitle = graphs.Title
						}).ToListAsync();

			return res.GroupBy(e => e.ObjectiveId).Select(e => new ObjectiveDetailDTO
			{
				Title = e.First().ObjectiveTitle,
				Variables = e.Select(grEl => new VariableDTO
				{
					Title = grEl.VariableTitle,
					IsStrict = grEl.VariableIsStrict
				})
			}).SingleOrDefault();
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
