namespace BornToCompile.HierarchyBehaviour.Options
{
	public class AddressableBehaviourOptions : BehaviourOptionsInitialize
	{
		public string Key { get; set; }
	}
	
	public class AddressableBehaviourOptions<TArgs> : BehaviourOptionsInitialize<TArgs>
	{
		public string Key { get; set; }
	}
}