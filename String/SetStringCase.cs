// Custom Action by DumbGameDev
// www.dumbgamedev.com


using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.String)]
	[Tooltip("Change the case formating of a string.")]
	public class SetStringCase : FsmStateAction
	{

        [Title("String Case Conversion")]
        public enum stringCase { Uppcase, Lowercase, Titlecase }
        public stringCase stringType;

        [RequiredField]
		public FsmString inputString;

        public FsmString outputString;
		
        public bool everyFrame;

        public override void Reset()
		{
			inputString = null;
			outputString = null;
			everyFrame = false;
            
		}

		public override void OnEnter()
		{
			DoChangeCase();
			
			if (!everyFrame)
				Finish();
		}

		public override void OnUpdate()
		{
            DoChangeCase();
		}
		
		void DoChangeCase()
		{

            stringCase value = stringType;

            if (value == stringCase.Lowercase)
            {

                outputString.Value = inputString.Value.ToLower();
            }

            else if (value == stringCase.Uppcase)
            {

                outputString.Value = inputString.Value.ToUpper();
            }

            else if (value == stringCase.Titlecase)
            {

                outputString.Value = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(inputString.Value.ToLower());
                
            }

        }
		
	}
}