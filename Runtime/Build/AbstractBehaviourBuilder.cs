using BornToCompile.HierarchyBehaviour.Options;
using BornToCompile.HierarchyBehaviour.Utilities;
using UnityEngine;

namespace BornToCompile.HierarchyBehaviour.Build
{
	public abstract class AbstractBehaviourBuilder<TOptions>
		where TOptions : BehaviourOptions, new()
	{
		protected readonly TOptions options;

		protected AbstractBehaviourBuilder()
		{
			options = new TOptions();
		}

		protected AbstractBehaviourBuilder(TOptions options)
		{
			this.options = options;
		}

		public void AsChild(Transform parent, bool worldPositionStays = true)
		{
			options.Parent.Transform = parent;
			options.Parent.WorldPositionStays = worldPositionStays;
		}

		public void Replace<TBehaviour>(TBehaviour toReplace) where TBehaviour : MonoBehaviour
		{
			options.Replace.GameObject = toReplace != null ? toReplace.gameObject : default;
		}

		public void DontDestroyOnLoad()
		{
			options.DontDestroyOnLoad = true;
		}

		public void AddComponent<T>(T component) where T : Component
		{
			options.Components.Add(component.GetType());
		}

		public virtual TBehaviour Apply<TBehaviour>(TBehaviour behaviour) where TBehaviour : MonoBehaviour
		{
			BehaviourUtils.AddComponents(behaviour, options.Components);

			if (options.Parent.Transform)
			{
				BehaviourUtils.SetParent(behaviour, options.Parent.Transform, options.Parent.WorldPositionStays);
			}

			if (options.Replace.GameObject)
			{
				BehaviourUtils.Replace(behaviour, options.Replace.GameObject);
			}

			if (options.DontDestroyOnLoad)
			{
				BehaviourUtils.DontDestroyOnLoad(behaviour);
			}

			return behaviour;
		}
	}
}