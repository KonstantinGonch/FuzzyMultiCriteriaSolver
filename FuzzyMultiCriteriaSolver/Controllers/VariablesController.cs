using FuzzyMultiCriteriaSolver.Managers;
using FuzzyMultiCriteriaSolver.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuzzyMultiCriteriaSolver.Controllers
{
	[ApiController]
	[Route("api/variables")]
	public class VariablesController : ControllerBase
	{
		private IVariableStorageManager _variableStorageManager;

		public VariablesController(IVariableStorageManager variableStorageManager)
		{
			_variableStorageManager = variableStorageManager;
		}

		[HttpGet]
		[Route("getObjectiveVariables/{objectiveId}")]
		public async Task<IEnumerable<Variable>> GetObjectiveVariables([FromRoute]long objectiveId)
		{
			return await _variableStorageManager.GetObjectiveVariables(objectiveId);
		}

		[HttpGet]
		[Route("getVariable/{id}")]
		public async Task<Variable> GetVariable([FromRoute]long id)
		{
			return await _variableStorageManager.GetVariable(id);
		}

		[HttpPost]
		[Route("add")]
		public async Task<Variable> AddVariable([FromBody]Variable variable)
		{
			return await _variableStorageManager.AddVariable(variable);
		}

		[HttpPut]
		[Route("update")]
		public async Task<Variable> UpdateVariable([FromBody] Variable variable)
		{
			return await _variableStorageManager.UpdateVariable(variable);
		}

		[HttpDelete]
		[Route("delete")]
		public async Task<bool> DeleteVariable([FromBody]long id)
		{
			return await _variableStorageManager.DeleteVariable(id);
		}

	}
}
