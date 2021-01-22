using System;
using System.Collections.Generic;
using UnityEngine;

namespace BornToCompile.HierarchyBehaviour.Options
{
	public class BehaviourOptionsInitialize : BehaviourOptions
	{
		public InitializeOptions Initialize { get; set; } = new InitializeOptions();
	}

	public class BehaviourOptionsInitialize<TArgs> : BehaviourOptions
	{
		public InitializeOptions<TArgs> Initialize { get; set; } = new InitializeOptions<TArgs>();
	}

	public class BehaviourOptions
	{
		public ParentOptions Parent { get; set; } = new ParentOptions();
		public ReplaceOptions Replace { get; set; } = new ReplaceOptions();

		public List<Type> Components { get; set; } = new List<Type>();
		public bool DontDestroyOnLoad { get; set; }
	}

	public class InitializeOptions
	{
		public bool Should { get; set; }
	}

	public class InitializeOptions<TArgs>
	{
		public bool Should { get; set; }
		public TArgs Args { get; set; }
	}


	public class ParentOptions
	{
		public Transform Transform { get; set; }
		public bool WorldPositionStays { get; set; }
	}

	public class ReplaceOptions
	{
		public GameObject GameObject { get; set; }
	}
}