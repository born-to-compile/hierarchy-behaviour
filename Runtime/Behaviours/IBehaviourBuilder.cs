using UnityEngine;

namespace BornToCompile.HierarchyBehaviour.Behaviours
{
	public interface IBehaviour<out TBehaviour> where TBehaviour : IBehaviour<TBehaviour>
	{
		TBehaviour AsChild(Transform parent, bool worldPositionStays = true);

		TBehaviour Replace<T>(T toReplace) where T : MonoBehaviour;

		TBehaviour AddComponent<TComponent>(TComponent component) where TComponent : Component;
		TBehaviour DontDestroyOnLoad();

		TBehaviour Initialize();
	}

	public interface IBehaviour<out TBehaviour, in TArgs> where TBehaviour : IBehaviour<TBehaviour, TArgs>
	{
		TBehaviour AsChild(Transform parent, bool worldPositionStays = true);

		TBehaviour Replace<T>(T toReplace) where T : MonoBehaviour;

		TBehaviour AddComponent<TComponent>(TComponent component) where TComponent : Component;
		TBehaviour DontDestroyOnLoad();

		TBehaviour Initialize(TArgs args);
	}
}