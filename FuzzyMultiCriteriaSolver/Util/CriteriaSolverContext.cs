using FuzzyMultiCriteriaSolver.Models;
using Microsoft.EntityFrameworkCore;

namespace FuzzyMultiCriteriaSolver.Util
{
	public class CriteriaSolverContext : DbContext
	{
		public CriteriaSolverContext(DbContextOptions opts) : base(opts)
		{

		}

		public DbSet<ANFISInstance> AnfisInstances { get; set; }
		public DbSet<GraphicalReportUnit> GraphicalReportUnits { get; set; }
		public DbSet<MembershipFunction> MembershipFunctions { get; set; }
		public DbSet<Objective> Objectives { get; set; }
		public DbSet<UserRequest> UserRequests { get; set; }
		public DbSet<UserVariableInput> UserVariableInputs { get; set; }
		public DbSet<Variable> Variables { get; set; }
	}
}
