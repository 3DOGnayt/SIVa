//------------------------------------------------------------------------------
// <auto-generated>
//		This code was generated by a tool (Genesis v2.4.7.0).
//
//
//		Changes to this file may cause incorrect behavior and will be lost if
//		the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using JCMG.EntitasRedux;

public class GameCleanupFeature : Feature
{
	#if !ENTITAS_REDUX_NO_SHARED_CONTEXT
	public GameCleanupFeature() : base()
	{
		AddSystems(Contexts.SharedInstance.Game);
	}
	#endif

	public GameCleanupFeature(IContext<GameEntity> context) : base()
	{
		AddSystems(context);
	}

	private void AddSystems(IContext<GameEntity> context)
	{

	}
}