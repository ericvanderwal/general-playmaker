// Custom Action by DumbGameDev
// www.dumbgamedev.com

using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets AudioSource component clip start time.")]
	public class SetAudioStartTime : ComponentAction<AudioSource>
	{
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		public FsmOwnerDefault gameObject;
		public FsmFloat startTime;

		public override void Reset()
		{
			gameObject = null;
			startTime = null;
		}

		public override void OnEnter()
		{
			var go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (UpdateCache(go))

			{

				audio.time = startTime.Value;
				audio.Play ();

			}


		}

	}	

}