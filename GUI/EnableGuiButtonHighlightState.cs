using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

[ActionCategory(ActionCategory.GUI)]
[Tooltip("Enable Gui Button to Select State")]
public class EnableGuiButtonHighlightState : FsmStateAction
{

		[ObjectType(typeof(UnityEngine.UI.Button))]
		public FsmObject gameButtonGui;
		private UnityEngine.UI.Button button;

	// Code that runs on entering the state.
	public override void Reset()
	{
			gameButtonGui = null;
		
	}

	// Code that runs every frame.
	public override void OnEnter()
	{

			button = (UnityEngine.UI.Button)gameButtonGui.Value;
			button.OnSelect (null);
		
	}


}

}