// by MDS
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
    [ActionCategory(ActionCategory.Physics)]
    [Tooltip("Applies knock to a game object using a Rigidbody, NavmeshAgent or Character Controller with Itween.")]
    public class KnockbackActionItween : FsmStateAction
    {
        [RequiredField]
        [Tooltip("The object to knockback")]
        public FsmOwnerDefault knockThisBack;
        [Tooltip("Select type- selected component must be present on object or it won't work")]
        public enum objectType {NavMeshAgent,RigidBody,CharacterController }
        public objectType type;
        private Vector3 npcPos;
        [Tooltip("The hitPoint from a cast")]
        public FsmVector3 hitPoint;
        [Tooltip("How far to knock the object back")]
        public FsmFloat knockBackAmount;
		[Tooltip("Itween time for character controller type only. This prevents instant transport issues")]
		[TitleAttribute("iTween Character Controller")]
		public FsmFloat time;
        Rigidbody rb;
        UnityEngine.AI.NavMeshAgent nav;
        CharacterController cc;
		private GameObject ccGameObject;

        public bool everyFrame;

        public override void Reset()
        {
            everyFrame = false;
			time = null;
        }

        public override void OnEnter()
        {


            DoKnockBackAction();

            if (!everyFrame)
            {
                Finish();
            }
        }

        public override void OnUpdate()
        {
            DoKnockBackAction();
        }

        void DoKnockBackAction()
        {
            var go = Fsm.GetOwnerDefaultTarget(knockThisBack);
            if (go == null)
            {
                return;
            }

            int eValue = (int)type;

            switch(eValue)
            {
                case 0:
                    // navmesh
                    nav = go.GetComponent<UnityEngine.AI.NavMeshAgent>();
                    npcPos = go.transform.position;
                    Vector3 direction1 = (npcPos - hitPoint.Value).normalized;
                    direction1 = direction1 * knockBackAmount.Value / 2;
                    direction1 = new Vector3(direction1.x, 0f, direction1.z);
                    nav.Move(direction1);
                    

                    break; 
                case 1:
                    // rb
                    rb = go.GetComponent<Rigidbody>();
                    npcPos = go.transform.position;
                    Vector3 direction = (npcPos - hitPoint.Value).normalized;
                    direction = direction * knockBackAmount.Value;
                    direction = new Vector3(direction.x, 0f, direction.z);
                    rb.AddForce(direction, ForceMode.VelocityChange);

                    break;
			case 2:
                // cc
				npcPos = go.transform.position;
				Vector3 direction2 = (npcPos - hitPoint.Value).normalized;
				direction2 = direction2 * knockBackAmount.Value;
				direction2 = new Vector3 (direction2.x, 0f, direction2.z);
				iTween.MoveBy (go, iTween.Hash ("x", direction2.x, "z", direction2.z, "time", time.Value));

                    break;

            }

           


          


        }


    }
}