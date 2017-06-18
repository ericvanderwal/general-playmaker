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
	[Tooltip ("Calculate the nessesary throw/projectile speed to reach a specific target by vector3")]
	public class CalculateProjectileThrowSpeed : FsmStateAction
    {

	    [UIHint(UIHint.Description)]
	    public string tweenIdDescription = "The returned results -throw speed- is a vector3 force which can be used with the custom action -Projectile Apply Force- to move your projectile";
	    
	    
	    public FsmVector3 origin;
	    public FsmVector3 target;
	    public FsmFloat timeToTarget;
	    
	    [UIHint(UIHint.Variable)]
	    public FsmVector3 throwSpeed;

	    public FsmBool everyFrame;
	       
	    public override void Reset()
	    {
		    
		    origin = null;
		    target = null;
		    timeToTarget = null;
		    throwSpeed = null;
			everyFrame = false;

	    }


	    public override void OnEnter()
	    {

		    if (!everyFrame.Value)
		    {
			    throwSpeed.Value = calculateBestThrowSpeed(origin.Value, target.Value, timeToTarget.Value);
			    Finish();
		    }
		    
	    }
	    
	    
	    public override void OnUpdate()
	    {
		    if (everyFrame.Value)
		    {
			    throwSpeed.Value = calculateBestThrowSpeed(origin.Value, target.Value, timeToTarget.Value);
		    }
	    }
	    
	   
	    private Vector3 calculateBestThrowSpeed(Vector3 origin, Vector3 target, float timeToTarget) {
     // calculate vectors
		    Vector3 toTarget = target - origin;
		    Vector3 toTargetXZ = toTarget;
		    toTargetXZ.y = 0;
		    
     // calculate xz and y
		    float y = toTarget.y;
		    float xz = toTargetXZ.magnitude;
		    
     // calculate starting speeds for xz and y. Physics forumulase deltaX = v0 * t + 1/2 * a * t * t
     // where a is "-gravity" but only on the y plane, and a is 0 in xz plane.
     // so xz = v0xz * t => v0xz = xz / t
     // and y = v0y * t - 1/2 * gravity * t * t => v0y * t = y + 1/2 * gravity * t * t => v0y = y / t + 1/2 * gravity * t
		    float t = timeToTarget;
		    float v0y = y / t + 0.5f * Physics.gravity.magnitude * t;
		    float v0xz = xz / t;
		    
     // create result vector for calculated starting speeds
		    Vector3 result = toTargetXZ.normalized;        // get direction of xz but with magnitude 1
		    result *= v0xz;                                // set magnitude of xz to v0xz (starting speed in xz plane)
		    result.y = v0y;                                // set y to v0y (starting speed of y plane)
		    
		    return result;
	    }

    }
}
