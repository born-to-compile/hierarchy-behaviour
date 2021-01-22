using Duck.HierarchyBehaviour;
using UnityEngine;

namespace BornToCompile.HierarchyBehaviour
{
	public static class Hierarchy
	{
		public static BehaviourReference<TBehaviour> Behaviour<TBehaviour>()
			where TBehaviour : MonoBehaviour
		{
			return new BehaviourReference<TBehaviour>();
		}

		public static BehaviourReference<TBehaviour, TArgs> Behaviour<TBehaviour, TArgs>()
			where TBehaviour : MonoBehaviour, IHierarchyBehaviour<TArgs>
		{
			return new BehaviourReference<TBehaviour, TArgs>();
		}

		public static CloneBehaviourReference<TBehaviour> CloneBehaviour<TBehaviour>(TBehaviour toClone)
			where TBehaviour : MonoBehaviour
		{
			return new CloneBehaviourReference<TBehaviour>(toClone);
		}

		public static CloneBehaviourReference<TBehaviour, TArgs> CloneBehaviour<TBehaviour, TArgs>(TBehaviour toClone)
			where TBehaviour : MonoBehaviour, IHierarchyBehaviour<TArgs>
		{
			return new CloneBehaviourReference<TBehaviour, TArgs>(toClone);
		}

		public static ResourceBehaviourReference<TBehaviour> ResourceBehaviour<TBehaviour>(string path)
			where TBehaviour : MonoBehaviour
		{
			return new ResourceBehaviourReference<TBehaviour>(path);
		}

		public static ResourceBehaviourReference<TBehaviour, TArgs> ResourceBehaviour<TBehaviour, TArgs>(string path)
			where TBehaviour : MonoBehaviour, IHierarchyBehaviour<TArgs>
		{
			return new ResourceBehaviourReference<TBehaviour, TArgs>(path);
		}

		public static AddressableBehaviour<TBehaviour> AddressableBehaviour<TBehaviour>(string key)
			where TBehaviour : MonoBehaviour
		{
			return new AddressableBehaviour<TBehaviour>(key);
		}

		public static AddressableBehaviour<TBehaviour, TArgs> AddressableBehaviour<TBehaviour, TArgs>(string key)
			where TBehaviour : MonoBehaviour, IHierarchyBehaviour<TArgs>
		{
			return new AddressableBehaviour<TBehaviour, TArgs>(key);
		}
	}
}