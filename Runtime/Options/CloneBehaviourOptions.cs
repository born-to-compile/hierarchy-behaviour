namespace BornToCompile.HierarchyBehaviour.Options
{
	public class CloneBehaviourOptions<TBehaviour> : BehaviourOptionsInitialize
	{
		public TBehaviour Original { get; set; }
	}
	
	public class CloneBehaviourOptions<TBehaviour, TArgs> : BehaviourOptionsInitialize<TArgs>
	{
		public TBehaviour Original { get; set; }
	}
}