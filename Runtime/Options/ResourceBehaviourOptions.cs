namespace BornToCompile.HierarchyBehaviour.Options
{
	public class ResourceBehaviourOptions : BehaviourOptionsInitialize
	{
		public string Path { get; set; }
	}
	
	public class ResourceBehaviourOptions<TArgs> : BehaviourOptionsInitialize<TArgs>
	{
		public string Path { get; set; }
	}
}