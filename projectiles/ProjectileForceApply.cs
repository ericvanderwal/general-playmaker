// Custom Action by DumbGameDev
// www.dumbgamedev.com
// Eric Vander Wal
// Thanks to Script from Unity Forums: http://answers.unity3d.com/questions/248788/calculating-ball-trajectory-in-full-3d-world.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	
	[ActionCategory("Custom")]
	[Tooltip ("Apply force to a rigidbody gameobject using force mode velocity change.")]
	public class ProjectileForceApply : FsmStateAction
	{
		
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("Gameobject to apply force to. Must have rigidbody")]
		public FsmOwnerDefault gameObject;
	
		public FsmVector3 forceAmount;
		
		public FsmBool everyFrame;
		
		private Rigidbody theBody;
		
		public override void Reset()
		{
			
			forceAmount = null;
			everyFrame = false;
			
		}
		
		
		public override void OnEnter()
		{
			var go = Fsm.GetOwnerDefaultTarget(gameObject);
			theBody = go.GetComponent<Rigidbody>();
			
			
			if (!everyFrame.Value)
			{
				doForce();
				Finish();
			}
			
		}
		
		
		public override void OnUpdate()
		{
			if (everyFrame.Value)
			{
				doForce();
			}
		}
		
		
		void doForce()
		{
			var go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (go == null)
			{
				return;
			}
			
			theBody.AddForce(forceAmount.Value, ForceMode.VelocityChange);
			
		}
		
	}
}
