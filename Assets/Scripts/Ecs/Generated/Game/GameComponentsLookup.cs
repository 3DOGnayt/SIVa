//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.7.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using JCMG.EntitasRedux;

public static class GameComponentsLookup
{
	public const int Destroyed = 0;
	public const int Link = 1;
	public const int Uid = 2;
	public const int GameDestroyedAddedListener = 3;
	public const int LinkRemovedListener = 4;

	public const int TotalComponents = 5;

	public static readonly string[] ComponentNames =
	{
		"Destroyed",
		"Link",
		"Uid",
		"GameDestroyedAddedListener",
		"LinkRemovedListener"
	};

	public static readonly System.Type[] ComponentTypes =
	{
		typeof(Ecs.Common.Components.DestroyedComponent),
		typeof(Ecs.Common.Components.LinkComponent),
		typeof(Ecs.Common.Components.UidComponent),
		typeof(GameDestroyedAddedListenerComponent),
		typeof(LinkRemovedListenerComponent)
	};

	public static readonly Dictionary<Type, int> ComponentTypeToIndex = new Dictionary<Type, int>
	{
		{ typeof(Ecs.Common.Components.DestroyedComponent), 0 },
		{ typeof(Ecs.Common.Components.LinkComponent), 1 },
		{ typeof(Ecs.Common.Components.UidComponent), 2 },
		{ typeof(GameDestroyedAddedListenerComponent), 3 },
		{ typeof(LinkRemovedListenerComponent), 4 }
	};

	/// <summary>
	/// Returns a component index based on the passed <paramref name="component"/> type; where an index cannot be found
	/// -1 will be returned instead.
	/// </summary>
	/// <param name="component"></param>
	public static int GetComponentIndex(IComponent component)
	{
		return GetComponentIndex(component.GetType());
	}

	/// <summary>
	/// Returns a component index based on the passed <paramref name="componentType"/>; where an index cannot be found
	/// -1 will be returned instead.
	/// </summary>
	/// <param name="componentType"></param>
	public static int GetComponentIndex(Type componentType)
	{
		return ComponentTypeToIndex.TryGetValue(componentType, out var index) ? index : -1;
	}
}
