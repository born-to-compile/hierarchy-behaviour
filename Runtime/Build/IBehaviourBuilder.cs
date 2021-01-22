using UnityEngine;

namespace BornToCompile.HierarchyBehaviour.Build
{
	public interface IBehaviourBuilder
	{
		void AsChild(Transform parent, bool worldPositionStays = true);
		void Replace<T>(T toReplace) where T : MonoBehaviour;
		void AddComponent<T1>(T1 component) where T1 : Component;
	}
}