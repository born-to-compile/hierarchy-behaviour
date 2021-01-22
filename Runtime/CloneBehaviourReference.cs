using BornToCompile.HierarchyBehaviour.Behaviours.Synchronous;
using BornToCompile.HierarchyBehaviour.Options;
using BornToCompile.HierarchyBehaviour.Utilities;
using Duck.HierarchyBehaviour;
using UnityEngine;

namespace BornToCompile.HierarchyBehaviour
{
	public class CloneBehaviourReference<TObject> : AbstractBehaviour<TObject>
		where TObject : MonoBehaviour
	{
		private readonly TObject original;

		public CloneBehaviourReference(TObject original)
		{
			this.original = original;
		}

		public CloneBehaviourReference(CloneBehaviourOptions<TObject> options) : base(options)
		{
			original = options.Original;
		}

		protected override TObject Instantiate() => BehaviourUtils.Clone(original);
	}

	public class CloneBehaviourReference<TBehaviour, TArgs> : AbstractBehaviour<TBehaviour, TArgs>
		where TBehaviour : MonoBehaviour, IHierarchyBehaviour<TArgs>
	{
		private readonly TBehaviour original;

		public CloneBehaviourReference(TBehaviour original)
		{
			this.original = original;
		}

		public CloneBehaviourReference(CloneBehaviourOptions<TBehaviour, TArgs> options) : base(options)
		{
			original = options.Original;
		}

		protected override TBehaviour Instantiate() => BehaviourUtils.Clone(original);
	}
}