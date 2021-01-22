using UnityEngine;

namespace BornToCompile.HierarchyBehaviour.Behaviours.Synchronous
{
	public interface IBehaviourBuilder<out TBehaviour> : IBehaviour<IBehaviourBuilder<TBehaviour>>
	{
		TBehaviour Create();
		TBehaviour Create<TRef>(ref TRef reference) where TRef : MonoBehaviour;
	}

	public interface IBehaviourBuilder<out TBehaviour, in TArgs> : IBehaviour<IBehaviourBuilder<TBehaviour, TArgs>, TArgs>
	{
		TBehaviour Create();
		TBehaviour Create<TRef>(ref TRef reference) where TRef : MonoBehaviour;
	}
}