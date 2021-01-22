using BornToCompile.HierarchyBehaviour.Behaviours.Synchronous;
using BornToCompile.HierarchyBehaviour.Options;
using BornToCompile.HierarchyBehaviour.Utilities;
using Duck.HierarchyBehaviour;
using UnityEngine;

namespace BornToCompile.HierarchyBehaviour
{
	public class BehaviourReference<TBehaviour> : AbstractBehaviour<TBehaviour>
		where TBehaviour : MonoBehaviour
	{
		public BehaviourReference()
		{
		}

		public BehaviourReference(BehaviourOptionsInitialize options) : base(options)
		{
		}

		protected override TBehaviour Instantiate() => BehaviourUtils.Create<TBehaviour>();
	}

	public class BehaviourReference<TBehaviour, TArgs> : AbstractBehaviour<TBehaviour, TArgs>
		where TBehaviour : MonoBehaviour, IHierarchyBehaviour<TArgs>
	{
		public BehaviourReference()
		{
		}

		public BehaviourReference(BehaviourOptionsInitialize<TArgs> options) : base(options)
		{
		}

		protected override TBehaviour Instantiate() => BehaviourUtils.Create<TBehaviour>();
	}
}