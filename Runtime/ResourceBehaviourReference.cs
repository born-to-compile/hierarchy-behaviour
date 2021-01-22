using BornToCompile.HierarchyBehaviour.Behaviours.Synchronous;
using BornToCompile.HierarchyBehaviour.Options;
using BornToCompile.HierarchyBehaviour.Utilities;
using Duck.HierarchyBehaviour;
using UnityEngine;

namespace BornToCompile.HierarchyBehaviour
{
	public class ResourceBehaviourReference<TBehaviour> : AbstractBehaviour<TBehaviour>
		where TBehaviour : MonoBehaviour
	{
		private readonly string resourcePath;

		public ResourceBehaviourReference(string path)
		{
			resourcePath = path;
		}

		public ResourceBehaviourReference(ResourceBehaviourOptions options) : base(options)
		{
			resourcePath = options.Path;
		}

		protected override TBehaviour Instantiate() => BehaviourUtils.InstantiateResource<TBehaviour>(resourcePath);
	}

	public class ResourceBehaviourReference<TBehaviour, TArgs> : AbstractBehaviour<TBehaviour, TArgs>
		where TBehaviour : MonoBehaviour, IHierarchyBehaviour<TArgs>
	{
		private readonly string resourcePath;

		public ResourceBehaviourReference(string path)
		{
			resourcePath = path;
		}

		public ResourceBehaviourReference(ResourceBehaviourOptions<TArgs> options) : base(options)
		{
			resourcePath = options.Path;
		}

		protected override TBehaviour Instantiate() => BehaviourUtils.InstantiateResource<TBehaviour>(resourcePath);
	}
}