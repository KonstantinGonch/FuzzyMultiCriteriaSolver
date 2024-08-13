using FuzzyMultiCriteriaSolver.Managers;
using FuzzyMultiCriteriaSolver.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuzzyMultiCriteriaSolver.Controllers
{
	[ApiController]
	[Route("api/objectives")]
	public class TasksController : ControllerBase
	{
		private IObjectivesStorageManager _objectiveStorageManager { get; set; }

		public TasksController(IObjectivesStorageManager objectiveStorageManager)
		{
			_objectiveStorageManager = objectiveStorageManager;
		}

		[HttpGet]
		[Route("all")]
		public async Task<IEnumerable<Objective>> GetObjectives()
		{
			return await _objectiveStorageManager.GetAll();
		}

		[HttpGet]
		[Route("get/{id}")]
		public async Task<Objective> GetObjective([FromRoute] long id)
		{
			return await _objectiveStorageManager.GetObjective(id);
		}

		[HttpPost]
		[Route("add")]
		public async Task<Objective> AddObjective([FromBody] Objective objective)
		{
			return await _objectiveStorageManager.SaveObjective(objective);
		}

		[HttpPut]
		[Route("update")]
		public async Task<Objective> UpdateObjective([FromBody] Objective objective)
		{
			return await _objectiveStorageManager.UpdateObjective(objective);
		}

		[HttpDelete]
		[Route("delete")]
		public async Task<bool> DeleteObjective([FromBody] long id)
		{
			return await _objectiveStorageManager.DeleteObjective(id);
		}
	}
}
