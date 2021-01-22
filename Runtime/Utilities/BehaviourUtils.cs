using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BornToCompile.AsyncUtilities;
using Duck.HierarchyBehaviour;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Object = UnityEngine.Object;

namespace BornToCompile.HierarchyBehaviour.Utilities
{
	public static class BehaviourUtils
	{
		public static T Create<T>() where T : MonoBehaviour
		{
			return new GameObject(typeof(T).Name).AddComponent<T>();
		}

		public static void SetParent<T>(T behaviour, Transform parent, bool worldPositionStays) where T : MonoBehaviour
		{
			behaviour.transform.SetParent(parent, worldPositionStays);
		}

		public static void Initialize<T>(T behaviour) where T : MonoBehaviour
		{
			if (behaviour is IHierarchyBehaviour hierarchyBehaviour)
			{
				hierarchyBehaviour?.Initialize();
			}
		}

		public static void Initialize<TBehaviour, TArgs>(TBehaviour behaviour, TArgs args) where TBehaviour : MonoBehaviour
		{
			if (behaviour is IHierarchyBehaviour<TArgs> hierarchyBehaviour)
			{
				hierarchyBehaviour?.Initialize(args);
			}
		}

		public static void AddComponents<T>(T behaviour, IEnumerable<Type> components) where T : MonoBehaviour
		{
			foreach (var component in components)
			{
				behaviour.gameObject.AddComponent(component);
			}
		}

		public static TObject InstantiateResource<TObject>(string path)
			where TObject : Object
		{
			var loadedBehaviour = Resources.Load<TObject>(path);
			var behaviour = Object.Instantiate(loadedBehaviour);
			behaviour.name = loadedBehaviour.name;
			return behaviour;
		}

		public static TObject Clone<TObject>(TObject original)
			where TObject : Object
		{
			var behaviour = Object.Instantiate(original);
			behaviour.name = original.name;
			return behaviour;
		}

		public static void DontDestroyOnLoad<TObject>(TObject gameObject)
			where TObject : Object
		{
			Object.DontDestroyOnLoad(gameObject);
		}

		public static async Task<TObject> InstantiateAddressable<TObject>(string key)
			where TObject : Object
		{
			var loadedBehaviour = await Addressables.LoadAssetAsync<TObject>(key);
			var behaviour = Object.Instantiate(loadedBehaviour);
			behaviour.name = loadedBehaviour.name;
			return behaviour;
		}

		public static void Replace<T>(T behaviour, GameObject gameObject) where T : MonoBehaviour
		{
			var parent = gameObject.transform.parent;
			var siblingIndex = gameObject.transform.GetSiblingIndex();

			if (Application.isEditor)
			{
				Object.DestroyImmediate(gameObject);
			}
			else
			{
				Object.Destroy(gameObject);
			}

			SetParent(behaviour, parent, true);
			behaviour.transform.SetSiblingIndex(siblingIndex);
		}
	}
}