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
	[Tooltip ("Predict the flight path of a projectile (thrown object) in 3d using the Trajectory Predictor Asset.")]
	public class ProjectilePathPrediction3D : FsmStateAction
    {
	    
	    
	    [RequiredField]
	    public FsmOwnerDefault gameObject;
	    
	    public FsmVector3 startPosition;
	    public FsmVector3 velocity;
	    public FsmVector3 gravity;
	    public FsmFloat linearDrag;
	    
	    // [UIHint(UIHint.Description)]
	    // public string tweenIdDescription = "The returned results -throw speed- is a vector3 force which can be used with the custom action -Projectile Apply Force- to move your projectile";
	    
	    private TrajectoryPredictor tp;
	    
	    public FsmBool everyFrame;
	       
	    public override void Reset()
	    {
		    startPosition = null;
		    velocity = null;
		    gravity = new Vector3 (0f,-9.81f,0f);
		    linearDrag = 1;
			everyFrame = false;
		}


	    public override void OnEnter()
	    {
	    	
		    var go = Fsm.GetOwnerDefaultTarget(gameObject);
		    tp = go.GetComponent<TrajectoryPredictor>();

		    if (!everyFrame.Value)
		    {
			    predictPath();
			    Finish();
		    }
		    
	    }
	    
	    
	    public override void OnUpdate()
	    {
		    if (everyFrame.Value)
		    {
			    predictPath();
		    }
	    }
	    
	   
	    void predictPath() {
		    
		    var go = Fsm.GetOwnerDefaultTarget(gameObject);
		    if (go == null)
		    {
			    return;
		    }
		    
		    tp.Predict3D(startPosition.Value, velocity.Value, gravity.Value, linearDrag.Value);
		    
		    
	    }

    }
}
