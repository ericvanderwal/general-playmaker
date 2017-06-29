// Eric Vander Wal
// Dumb Game Dev
// www.dumbgamedev.com

using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Logic)]
	[Tooltip("Sends an Event based on a Int variable range. The lowest value of the first range is automatically set to 0. Set your max value. The lowest number for each next range is set automatically.")]
	public class IntRangeSwitch : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt intVariable;
		[CompoundArray("Int Ranges", "Range Max", "Send Event")]
		public FsmInt[] compareMax;
		public FsmEvent[] sendEvent;
		public bool everyFrame;
		
		// Private Variables
		private int smallestNumber;
		private int largestNumber;
		

		public override void Reset()
		{
			intVariable = null;
			compareMax = new FsmInt[1];
			sendEvent = new FsmEvent[1];
			everyFrame = false;

		}

		public override void OnEnter()
		{
			DoIntRange();
			
			if (!everyFrame)
				Finish();
		}

		public override void OnUpdate()
		{
			DoIntRange();
		}
		
		void DoIntRange()
		{
			if (intVariable.IsNone) {
				return;
			}
			
			// Setup Logic
			
			for (int i = 0; i < compareMax.Length; i++) 
			{
				
				if(compareMax[i].Value == compareMax[0].Value)
				{
					
					smallestNumber = 0;
					
				}
				else
				{
					smallestNumber = compareMax[i-1].Value + 1;
					
				}
				
				
				largestNumber = compareMax[i].Value;
			
				
				// Switch Logic
				if (intVariable.Value>=smallestNumber&intVariable.Value<=largestNumber)
						
					{
						
				{
					Fsm.Event(sendEvent[i]);
					return;
				}
				
				/// End switch Logic
					}
			}
		}
	}
}