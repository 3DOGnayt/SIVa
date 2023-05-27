//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.7.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ActionEntity
{
	static readonly Ecs.Common.Components.DestroyedComponent DestroyedComponent = new Ecs.Common.Components.DestroyedComponent();

	public bool IsDestroyed
	{
		get { return HasComponent(ActionComponentsLookup.Destroyed); }
		set
		{
			if (value != IsDestroyed)
			{
				var index = ActionComponentsLookup.Destroyed;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: DestroyedComponent;

					AddComponent(index, component);
				}
				else
				{
					RemoveComponent(index);
				}
			}
		}
	}
}

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.7.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ActionEntity : IDestroyedEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.7.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class ActionMatcher
{
	static JCMG.EntitasRedux.IMatcher<ActionEntity> _matcherDestroyed;

	public static JCMG.EntitasRedux.IMatcher<ActionEntity> Destroyed
	{
		get
		{
			if (_matcherDestroyed == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<ActionEntity>)JCMG.EntitasRedux.Matcher<ActionEntity>.AllOf(ActionComponentsLookup.Destroyed);
				matcher.ComponentNames = ActionComponentsLookup.ComponentNames;
				_matcherDestroyed = matcher;
			}

			return _matcherDestroyed;
		}
	}
}
