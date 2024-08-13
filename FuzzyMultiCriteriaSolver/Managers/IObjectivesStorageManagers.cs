using FuzzyMultiCriteriaSolver.Models;

namespace FuzzyMultiCriteriaSolver.Managers
{
	public interface IObjectivesStorageManager
	{
		public Task<IEnumerable<Objective>> GetAll();
		public Task<Objective> GetObjective(long id);
		public Task<Objective> SaveObjective(Objective objective);
		public Task<Objective> UpdateObjective(Objective objective);
		public Task<bool> DeleteObjective(long id);
	}
}
