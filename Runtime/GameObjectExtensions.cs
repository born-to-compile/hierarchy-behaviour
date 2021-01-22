using Duck.HierarchyBehaviour;
using UnityEngine;

namespace BornToCompile.HierarchyBehaviour
{
	public static class GameObjectExtensions
	{
		public static TBehaviour CreateChild<TBehaviour>(this Transform parent, BehaviourReference<TBehaviour> reference)
			where TBehaviour : MonoBehaviour
		{
			return reference
				.AsChild(parent)
				.Initialize()
				.Create();
		}

		public static TBehaviour CreateChild<TBehaviour, TArgs>(this Transform parent, BehaviourReference<TBehaviour, TArgs> reference, TArgs args)
			where TBehaviour : MonoBehaviour, IHierarchyBehaviour<TArgs>
		{
			return reference
				.AsChild(parent)
				.Initialize(args)
				.Create();
		}
		
		
		public static TBehaviour CreateChild<TBehaviour>(this BehaviourReference<TBehaviour> reference, Transform parent)
			where TBehaviour : MonoBehaviour
		{
			return reference
				.AsChild(parent)
				.Initialize()
				.Create();
		}

		public static TBehaviour CreateChild<TBehaviour, TArgs>(this BehaviourReference<TBehaviour, TArgs> reference, TArgs args, Transform parent)
			where TBehaviour : MonoBehaviour, IHierarchyBehaviour<TArgs>
		{
			return reference
				.AsChild(parent)
				.Initialize(args)
				.Create();
		}
	}
}