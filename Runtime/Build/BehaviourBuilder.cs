using BornToCompile.HierarchyBehaviour.Options;
using BornToCompile.HierarchyBehaviour.Utilities;

namespace BornToCompile.HierarchyBehaviour.Build
{
	public sealed class BehaviourBuilder : AbstractBehaviourBuilder<BehaviourOptionsInitialize>
	{
		public BehaviourBuilder()
		{
		}

		public BehaviourBuilder(BehaviourOptionsInitialize options) : base(options)
		{
		}

		public void Initialize()
		{
			options.Initialize.Should = true;
		}

		public override TBehaviour Apply<TBehaviour>(TBehaviour behaviour)
		{
			if (options.Initialize.Should)
			{
				BehaviourUtils.Initialize(behaviour);
			}

			return base.Apply(behaviour);
		}
	}

	public sealed class BehaviourBuilder<TArgs> : AbstractBehaviourBuilder<BehaviourOptionsInitialize<TArgs>>
	{
		public BehaviourBuilder()
		{
		}

		public BehaviourBuilder(BehaviourOptionsInitialize<TArgs> options) : base(options)
		{
		}

		public void Initialize(TArgs args)
		{
			options.Initialize.Should = true;
			options.Initialize.Args = args;
		}

		public override TBehaviour Apply<TBehaviour>(TBehaviour behaviour)
		{
			if (options.Initialize.Should)
			{
				BehaviourUtils.Initialize(behaviour, options.Initialize.Args);
			}

			return base.Apply(behaviour);
		}
	}
}