//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.7.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity
{
	public GameDestroyedAddedListenerComponent GameDestroyedAddedListener { get { return (GameDestroyedAddedListenerComponent)GetComponent(GameComponentsLookup.GameDestroyedAddedListener); } }
	public bool HasGameDestroyedAddedListener { get { return HasComponent(GameComponentsLookup.GameDestroyedAddedListener); } }

	public void AddGameDestroyedAddedListener(System.Collections.Generic.List<IGameDestroyedAddedListener> newValue)
	{
		var index = GameComponentsLookup.GameDestroyedAddedListener;
		var component = (GameDestroyedAddedListenerComponent)CreateComponent(index, typeof(GameDestroyedAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceGameDestroyedAddedListener(System.Collections.Generic.List<IGameDestroyedAddedListener> newValue)
	{
		var index = GameComponentsLookup.GameDestroyedAddedListener;
		var component = (GameDestroyedAddedListenerComponent)CreateComponent(index, typeof(GameDestroyedAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyGameDestroyedAddedListenerTo(GameDestroyedAddedListenerComponent copyComponent)
	{
		var index = GameComponentsLookup.GameDestroyedAddedListener;
		var component = (GameDestroyedAddedListenerComponent)CreateComponent(index, typeof(GameDestroyedAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveGameDestroyedAddedListener()
	{
		RemoveComponent(GameComponentsLookup.GameDestroyedAddedListener);
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
public partial class GameEntity : IGameDestroyedAddedListenerEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.7.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher
{
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherGameDestroyedAddedListener;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> GameDestroyedAddedListener
	{
		get
		{
			if (_matcherGameDestroyedAddedListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.GameDestroyedAddedListener);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherGameDestroyedAddedListener = matcher;
			}

			return _matcherGameDestroyedAddedListener;
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
public partial class GameEntity
{
	public void AddGameDestroyedAddedListener(IGameDestroyedAddedListener value)
	{
		var listeners = HasGameDestroyedAddedListener
			? GameDestroyedAddedListener.value
			: new System.Collections.Generic.List<IGameDestroyedAddedListener>();
		listeners.Add(value);
		ReplaceGameDestroyedAddedListener(listeners);
	}

	public void RemoveGameDestroyedAddedListener(IGameDestroyedAddedListener value, bool removeComponentWhenEmpty = true)
	{
		var listeners = GameDestroyedAddedListener.value;
		listeners.Remove(value);
		if (removeComponentWhenEmpty && listeners.Count == 0)
		{
			RemoveGameDestroyedAddedListener();
		}
		else
		{
			ReplaceGameDestroyedAddedListener(listeners);
		}
	}
}
