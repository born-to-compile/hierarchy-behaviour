using System.Threading.Tasks;

namespace BornToCompile.HierarchyBehaviour.Behaviours.Asynchronous
{
	public interface IBehaviourBuilder<TBehaviour> : IBehaviour<IBehaviourBuilder<TBehaviour>>
	{
		Task<TBehaviour> CreateAsync();
	}

	public interface IBehaviourBuilder<TBehaviour, in TArgs> : IBehaviour<IBehaviourBuilder<TBehaviour, TArgs>, TArgs>
	{
		Task<TBehaviour> CreateAsync();
	}
}