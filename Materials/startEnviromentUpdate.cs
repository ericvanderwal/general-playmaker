// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Schedules an update of the environment texture.")]
	public class startEnviromentUpdate : FsmStateAction
	{
		[RequiredField]
		public bool everyFrame;

		public override void Reset()
		{
			everyFrame = false;
		}

		public override void OnEnter()
		{
			DoUpdate();
			
			if (!everyFrame)
				Finish();
		}
		
		public override void OnUpdate()
		{
			DoUpdate();
		}
		
		void DoUpdate()
		{
			DynamicGI.UpdateEnvironment();
		}
	}
}