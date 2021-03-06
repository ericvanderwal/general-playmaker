// Custom Action by DumbGameDev
// www.dumbgamedev.com

using UnityEngine;
using UnityEngine.AI;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory("Path")]
    [Tooltip("Start nav mesh agent path debugging. The should be calculated before using this action. Fires events based on path success.")]

	public class debugAgentPath : FsmStateAction
	{
        // Playmaker variables

        [RequiredField]
		[CheckForComponent(typeof(NavMeshAgent))]
		[Tooltip("Nav agent game object.")]
		public FsmOwnerDefault gameObject;

        [Tooltip("Fires event if the agent can reach the destination along this path. This path is completed.")]
        public FsmEvent pathCompleteEvent;

        [Tooltip("Fires event if the agent can partially reach the destination along this path. This path is partially completed")]
        public FsmEvent pathPartialEvent;

        [Tooltip("Fires event if the agent cannot reach the destination along this path. This path is invalid.")]
        public FsmEvent pathInvalidEvent;

        public FsmBool everyFrame;

        // private variables

        private NavMeshAgent agent;
    
        public override void Reset()
		{

			gameObject = null;
			everyFrame = false;
		}

		public override void OnEnter()
		{

            // get components from game objects
            var go = Fsm.GetOwnerDefaultTarget(gameObject);
            agent = go.GetComponent<NavMeshAgent>();


            if (!everyFrame.Value)
			{
                debugPath();
				Finish();
			}

        }

        public override void OnUpdate()
		{
			if (everyFrame.Value)
			{
                debugPath();
			}
		}

		void debugPath()
		{
			var go = Fsm.GetOwnerDefaultTarget(gameObject);
			if (go == null)
			{
				return;
			}

            NavMeshPath path = agent.path;
            
            if (path.status == NavMeshPathStatus.PathComplete)
            {
                Fsm.Event(pathCompleteEvent);
            }
            else if (path.status == NavMeshPathStatus.PathPartial)
            {
                Fsm.Event(pathPartialEvent);
            }
            else if (path.status == NavMeshPathStatus.PathInvalid)
            {
                Fsm.Event(pathInvalidEvent);
            }

        }

	}
}