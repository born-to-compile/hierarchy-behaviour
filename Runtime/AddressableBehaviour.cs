using System.Threading.Tasks;
using BornToCompile.HierarchyBehaviour.Behaviours.Asynchronous;
using BornToCompile.HierarchyBehaviour.Options;
using BornToCompile.HierarchyBehaviour.Utilities;
using Duck.HierarchyBehaviour;
using UnityEngine;

namespace BornToCompile.HierarchyBehaviour
{
	public sealed class AddressableBehaviour<TBehaviour> : AbstractBehaviourAsync<TBehaviour>
		where TBehaviour : MonoBehaviour
	{
		private string addressableKey;

		public AddressableBehaviour(string key)
		{
			addressableKey = key;
		}

		public AddressableBehaviour(AddressableBehaviourOptions options) : base(options)
		{
			addressableKey = options.Key;
		}

		protected override async Task<TBehaviour> Instantiate() => await BehaviourUtils.InstantiateAddressable<TBehaviour>(addressableKey);
	}

	public sealed class AddressableBehaviour<TBehaviour, TArgs> : AbstractBehaviourAsync<TBehaviour, TArgs>
		where TBehaviour : MonoBehaviour, IHierarchyBehaviour<TArgs>
	{
		private string addressableKey;

		public AddressableBehaviour(string key)
		{
			addressableKey = key;
		}

		public AddressableBehaviour(AddressableBehaviourOptions<TArgs> options) : base(options)
		{
			addressableKey = options.Key;
		}

		protected override async Task<TBehaviour> Instantiate() => await BehaviourUtils.InstantiateAddressable<TBehaviour>(addressableKey);
	}
}