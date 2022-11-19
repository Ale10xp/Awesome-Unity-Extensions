using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtensions {


#region LerpLookAt


	
	public static void LerpLookAt(this Transform who, Transform target, float smoothTime){


		Vector3 direction = target.transform.position - who.transform.position;
		Quaternion rotation = Quaternion.LookRotation(direction);
		Vector3 target_angle = new Vector3(rotation.x, rotation.y, rotation.z);

		who.localEulerAngles = LerpAngle(who.localEulerAngles, target_angle, smoothTime);


	}




#endregion

#region LookAt2D

	public static void LookAt2D(this Transform who, Vector2 targetPos){

		Vector2 lookDir = targetPos - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.localEulerAngles = new Vector3(0,0,angle);

	}

	public static void LookAt2D(this Transform who, Vector2 targetPos, float angleModifier){

		Vector2 lookDir = targetPos - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.localEulerAngles = new Vector3(0,0,angle + angleModifier);

	}


	public static  void LookAt2D(this Transform who, Vector3 targetPos){

		Vector2 lookDir = new Vector2(targetPos.x,targetPos.y) - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.localEulerAngles = new Vector3(0,0,angle);

	}
	
	public static  void LookAt2D(this Transform who, Vector3 targetPos, float angleModifier){

		Vector2 lookDir = new Vector2(targetPos.x,targetPos.y) - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.localEulerAngles = new Vector3(0,0,angle + angleModifier);

	}

	public static  void LookAt2D(this Transform who, Transform target){

		Vector2 lookDir = new Vector2(target.position.x,target.position.y) - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle);

	}

	public static  void LookAt2D(this Transform who, Transform target, float angleModifier){

		Vector2 lookDir = new Vector2(target.position.x,target.position.y) - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle + angleModifier);

	}

	public static  void LookAt2D(this Transform who, GameObject target){

		Vector2 lookDir = new Vector2(target.transform.position.x,target.transform.position.y) - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle);

	}

	public static  void LookAt2D(this Transform who, GameObject target, float angleModifier){

		Vector2 lookDir = new Vector2(target.transform.position.x,target.transform.position.y) - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle + angleModifier);

	}

	public static  void LookAt2D(this GameObject who, GameObject target){

		Vector2 lookDir = new Vector2(target.transform.position.x,target.transform.position.y) - new Vector2(who.transform.position.x,who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle);

	}

	public static  void LookAt2D(this GameObject who, GameObject target, float angleModifier){

		Vector2 lookDir = new Vector2(target.transform.position.x,target.transform.position.y) - new Vector2(who.transform.position.x,who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle + angleModifier);

	}

	public static  void LookAt2D(this GameObject who, Transform target){

		Vector2 lookDir = new Vector2(target.position.x,target.position.y) - new Vector2(who.transform.position.x,who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle);

	}

	public static  void LookAt2D(this GameObject who, Transform target, float angleModifier){

		Vector2 lookDir = new Vector2(target.position.x,target.position.y) - new Vector2(who.transform.position.x,who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle +angleModifier);

	}

	public static  void LookAt2D(this GameObject who, Vector3 targetPos){

		Vector2 lookDir = new Vector2(targetPos.x, targetPos.y) - new Vector2(who.transform.position.x,who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle);

	}

	public static  void LookAt2D(this GameObject who, Vector3 targetPos, float angleModifier){

		Vector2 lookDir = new Vector2(targetPos.x, targetPos.y) - new Vector2(who.transform.position.x,who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle + angleModifier);

	}

	public static  void LookAt2D(this GameObject who, Vector2 targetPos){

		Vector2 lookDir = targetPos - new Vector2(who.transform.position.x, who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle);

	}

	public static  void LookAt2D(this GameObject who, Vector2 targetPos, float angleModifier){

		Vector2 lookDir = targetPos - new Vector2(who.transform.position.x, who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle + angleModifier);

	}


	#endregion 

#region LerpLookAt2D


	public static void LerpLookAt2D(this Transform who, Vector2 targetPos,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = targetPos - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle);


        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }




	}

	public static void LerpLookAt2D(this Transform who, Vector2 targetPos, float angleModifier, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = targetPos - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle + angleModifier);


        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }




	}

	public static void LerpLookAt2D(this Transform who, Vector3 target,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.x, target.y) - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle);

		#region lerp
        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion


	}

	public static void LerpLookAt2D(this Transform who, Vector3 target,float angleModifier, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.x, target.y) - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle +angleModifier);

		#region lerp
        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion


	}

	public static void LerpLookAt2D(this Transform who, GameObject target, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.transform.position.x, target.transform.position.y) - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle);


		#region lerp
        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion


	}

	public static void LerpLookAt2D(this Transform who, GameObject target,float angleModifier, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.transform.position.x, target.transform.position.y) - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle +angleModifier);

		#region lerp
        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion


	}

	public static void LerpLookAt2D(this Transform who, Transform target, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.position.x, target.position.y) - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle);

		#region lerp
        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion


	}

	public static void LerpLookAt2D(this Transform who, Transform target, float angleModifier, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.position.x, target.position.y) - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle + angleModifier);

		#region lerp
        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion


	}

	public static void LerpLookAt2D(this GameObject who, Vector2 targetPos,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = targetPos - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0,0,angle);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

	public static void LerpLookAt2D(this GameObject who, Vector2 targetPos,float angleModifier, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = targetPos - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0, 0, angle + angleModifier);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

	public static void LerpLookAt2D(this GameObject who, Vector3 targetPos,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(targetPos.x, targetPos.y)  - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0,0,angle);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

	public static void LerpLookAt2D(this GameObject who, Vector3 targetPos,float angleModifier, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(targetPos.x, targetPos.y) - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0, 0, angle + angleModifier);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

	public static void LerpLookAt2D(this GameObject who, Transform target,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.position.x, target.position.y)  - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0,0,angle);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

	public static void LerpLookAt2D(this GameObject who, Transform target,float angleModifier, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.position.x, target.position.y)  - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0,0,angle + angleModifier);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

	public static void LerpLookAt2D(this GameObject who, GameObject target,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.transform.position.x, target.transform.position.y)  - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0,0,angle);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

	public static void LerpLookAt2D(this GameObject who, GameObject target,float angleModifier, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.transform.position.x, target.transform.position.y)  - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0,0,angle + angleModifier);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

#endregion

#region ReverseLookAt2D

	public static void ReverseLookAt2D(this Transform who, Vector2 targetPos){

		Vector2 lookDir = targetPos - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.localEulerAngles = new Vector3(0,0,angle+180f);

	}	

	public static void ReverseLookAt2D(this Transform who, Vector3 targetPos){

		Vector2 lookDir = new Vector2(targetPos.x,targetPos.y) - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.localEulerAngles = new Vector3(0,0,angle+180f);

	}

	public static void ReverseLookAt2D(this Transform who, GameObject target){

		Vector2 lookDir = new Vector2(target.transform.position.x,target.transform.position.y) - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle+180f);

	}

	public static void ReverseLookAt2D(this Transform who, Transform target){

		Vector2 lookDir = new Vector2(target.position.x,target.position.y) - new Vector2(who.position.x,who.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle+180f);

	}

	public static void ReverseLookAt2D(this GameObject who, Vector2 targetPos){

		Vector2 lookDir = targetPos - new Vector2(who.transform.position.x,who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle+180f);

	}

	public static void ReverseLookAt2D(this GameObject who, Vector3 targetPos){

		Vector2 lookDir = new Vector2(targetPos.x, targetPos.y) - new Vector2(who.transform.position.x,who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle+180f);

	}

	public static void ReverseLookAt2D(this GameObject who, Transform target){

		Vector2 lookDir = new Vector2(target.position.x,target.position.y) - new Vector2(who.transform.position.x,who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle+180f);

	}

	public static void ReverseLookAt2D(this GameObject who, GameObject target){

		Vector2 lookDir = new Vector2(target.transform.position.x,target.transform.position.y) - new Vector2(who.transform.position.x,who.transform.position.y);

		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;

		who.transform.localEulerAngles = new Vector3(0,0,angle+180f);

	}

#endregion 

#region LerpReverseLookAt2D

	public static void LerpReverseLookAt2D(this Transform who, Vector2 targetPos,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = targetPos - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle+180f);

		#region Lerp
        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion


	}

	public static void LerpReverseLookAt2D(this Transform who, Vector3 target,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.x, target.y) - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle+180f);

		#region lerp
        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion


	}

	public static void LerpReverseLookAt2D(this Transform who, GameObject target, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.transform.position.x, target.transform.position.y) - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle+180f);

		#region lerp
        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion


	}
	
	public static void LerpReverseLookAt2D(this Transform who, Transform target, float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.position.x, target.position.y) - new Vector2(who.position.x,who.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0,0,angle+180f);

		#region lerp
        nextRotation = who.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.localEulerAngles = new Vector3(lerpX,who.localEulerAngles.y,who.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,lerpY,who.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.localEulerAngles = new Vector3(who.localEulerAngles.x,who.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion


	}

	public static void LerpReverseLookAt2D(this GameObject who, Vector2 targetPos,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = targetPos - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0,0,angle+180f);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

	public static void LerpReverseLookAt2D(this GameObject who, Vector3 targetPos,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(targetPos.x, targetPos.y)  - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0,0,angle+180f);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

	public static void LerpReverseLookAt2D(this GameObject who, Transform target,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.position.x, target.position.y)  - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0,0,angle+180f);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}
	
	public static void LerpReverseLookAt2D(this GameObject who, GameObject target,float smoothTime){

		Vector3 currentRotation, nextRotation;
        currentRotation = who.transform.localEulerAngles;
        nextRotation = currentRotation;

		//Modification
        Vector2 lookDir = new Vector2(target.transform.position.x, target.transform.position.y)  - new Vector2(who.transform.position.x, who.transform.position.y);
		float angle =  Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg;
		who.transform.localEulerAngles = new Vector3(0,0,angle+180f);

		#region lerp
        nextRotation = who.transform.localEulerAngles;

        if (currentRotation.x != nextRotation.x)
        {
			float lerpX = Mathf.LerpAngle(currentRotation.x, nextRotation.x, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(lerpX,who.transform.localEulerAngles.y,who.transform.localEulerAngles.z);

            currentRotation.x = nextRotation.x;
        }

		if (currentRotation.y != nextRotation.y)
        {
			
			float lerpY = Mathf.LerpAngle(currentRotation.y, nextRotation.y, smoothTime);
			
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,lerpY,who.transform.localEulerAngles.z);

            currentRotation.y = nextRotation.y;
        }

		if (currentRotation.z != nextRotation.z)
        {
			
			float lerpZ = Mathf.LerpAngle(currentRotation.z, nextRotation.z, smoothTime);
            who.transform.localEulerAngles = new Vector3(who.transform.localEulerAngles.x,who.transform.localEulerAngles.y,lerpZ);

            currentRotation.z = nextRotation.z;
        }

		#endregion 



	}

#endregion

	

	public static void RevertDirection(this GameObject who){

		Vector3 actualRotation = who.transform.localEulerAngles;

		actualRotation = new Vector3(
			who.transform.localEulerAngles.x,
			who.transform.localEulerAngles.y,
			who.transform.localEulerAngles.z+180f);

		who.transform.localEulerAngles = actualRotation; 
	}

	public static void RevertDirection(this Transform who){

		Vector3 actualRotation = who.localEulerAngles;

		actualRotation = new Vector3(
			who.localEulerAngles.x,
			who.localEulerAngles.y,
			who.localEulerAngles.z+180f);

		who.localEulerAngles = actualRotation; 
	}


 //Version Jun/2021 1.10
#region Teleport

	public static void Teleport(this Transform who, Vector3 toWhere){


		who.position = new Vector3(toWhere.x, toWhere.y, toWhere.z);


	}

	public static void Teleport(this Transform who, Vector2 toWhere){


		who.position = new Vector3(toWhere.x, toWhere.y, who.position.z);
		

	}

	public static void Teleport(this Transform who, Transform toWhere){


		who.position = new Vector3(toWhere.position.x, toWhere.position.y, toWhere.position.z);


	}

	public static void Teleport(this Transform who, GameObject toWhere){


		who.position = new Vector3(toWhere.transform.position.x, toWhere.transform.position.y, toWhere.transform.position.z);


	}



	public static void Teleport(this GameObject who, Vector3 toWhere){


		who.transform.position = new Vector3(toWhere.x, toWhere.y, toWhere.z);


	}

	public static void Teleport(this GameObject who, Vector2 toWhere){


		who.transform.position = new Vector3(toWhere.x, toWhere.y, who.transform.position.z);
		

	}

	public static void Teleport(this GameObject who, Transform toWhere){


		who.transform.position = new Vector3(toWhere.position.x, toWhere.position.y, toWhere.position.z);


	}

	public static void Teleport(this GameObject who, GameObject toWhere){


		who.transform.position = new Vector3(toWhere.transform.position.x, toWhere.transform.position.y, toWhere.transform.position.z);
		

	}

#endregion


#region Vector3 Lerp Angle

	public static Vector3 LerpAngle(this Vector3 what, Vector3 newWhat, float smoothTime){

		//atribuição

		Vector3 currentWhat, nextWhat;
        currentWhat = what;
        nextWhat = currentWhat;

        what = new Vector3(newWhat.x,newWhat.y, newWhat.z);

        nextWhat = what;

        //Mudança
        if (currentWhat.x != nextWhat.x)
        {

            what.x = Mathf.LerpAngle(currentWhat.x, nextWhat.x, smoothTime);

            currentWhat.x = nextWhat.x;
        }

		if (currentWhat.y != nextWhat.y)
        {

            what.y = Mathf.LerpAngle(currentWhat.y, nextWhat.y, smoothTime);

            currentWhat.y = nextWhat.y;
        }

		if (currentWhat.z != nextWhat.z)
        {

            what.z = Mathf.LerpAngle(currentWhat.z, nextWhat.z, smoothTime);

            currentWhat.z = nextWhat.z;
        }


        //Retorno
		return what;



		
	}



#endregion

#region Move 

	public static void Move2d(this Transform who, Vector3 _position, float _speed ){

		who.position = Vector2.MoveTowards(who.position, _position, _speed * Time.deltaTime);

	}

	public static void Move(this Transform who, Vector3 _position, float _speed ){

		who.position = Vector3.MoveTowards(who.position, _position, _speed * Time.deltaTime);

	}

#endregion

}


