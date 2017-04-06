// Custom Action by DumbGameDev
// www.dumbgamedev.com

using UnityEngine;
using System.Collections;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets looping on the AudioSource component for a specific time range.")]
	public class SetAudioLoopTime : ComponentAction<AudioSource>
	{
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		public FsmOwnerDefault gameObject;
		public FsmFloat startTime;
		public FsmFloat endTime;
		public FsmEvent finishEvent;

		private float timer;
		private float trackLength;


		public override void Reset()
		{
			gameObject = null;
			startTime = null;
			endTime = null;
			finishEvent = null;
		}

		public override void OnEnter()
		{
			var go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (UpdateCache(go))
				
			{
				//set variables for onEnter
				timer = 0f;
				trackLength = endTime.Value - startTime.Value;


				//Play Audio Clip with Start and End Time
				playClipLength ();


				// End event if audio clip length is less than 0
				if (trackLength <= 0)
				{
					Fsm.Event(finishEvent);
					Finish();
					return;
				}

			}

		}

		public override void OnUpdate()
		{

			// Set a timer
			timer += Time.deltaTime; 


			// Timer vs Track length to trigger end event
			if (timer >= trackLength)
			{
				Finish();
				if (finishEvent != null)
				{
					Fsm.Event(finishEvent);
				}
			}

		}

		void playClipLength()
		{
				
			// Play audio clip for certain time values
				audio.time = startTime.Value;
				audio.Play ();
				audio.SetScheduledEndTime (AudioSettings.dspTime + (endTime.Value - startTime.Value));

		}
	}	

}