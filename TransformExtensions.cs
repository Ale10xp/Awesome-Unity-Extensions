using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformExtensions {

	#region ReverseLookAt2D

	public static void ReverseLookAt2D(this Transform who, Vector2 targetPos)
	{
		LookAt2D(who, (Vector3)targetPos, 180f);
	}

	public static void ReverseLookAt2D(this Transform who, Vector3 targetPos)
	{
		LookAt2D(who, targetPos, 180f);
	}

	public static void ReverseLookAt2D(this Transform who, GameObject target)
	{
		LookAt2D(who, target.transform.position, 180f);
	}

	public static void ReverseLookAt2D(this Transform who, Transform target)
	{
		LookAt2D(who, target.position, 180f);
	}


	#endregion

	#region LerpReverseLookAt2D

	public static void LerpReverseLookAt2D(this Transform who, Vector2 targetPos,float smoothTime)
	{
		LerpLookAt2D(who, (Vector3)targetPos, smoothTime, 180f);
	}

	public static void LerpReverseLookAt2D(this Transform who, Vector3 target,float smoothTime)
	{
		LerpLookAt2D(who, target, smoothTime, 180f);
	}

	public static void LerpReverseLookAt2D(this Transform who, GameObject target, float smoothTime)
	{
		LerpLookAt2D(who, target.transform.position, smoothTime, 180f);
	}
	
	public static void LerpReverseLookAt2D(this Transform who, Transform target, float smoothTime)
	{
		LerpLookAt2D(who, target.position, smoothTime, 180f);
	}



	#endregion

	#region LerpLookAt2D

	public static void LerpLookAt2D(this Transform who, Vector2 targetPos, float smoothTime, float angleModifier = 0)
	{
		LerpLookAt2D(who, (Vector3)targetPos, smoothTime, angleModifier);
	}

	public static void LerpLookAt2D(this Transform who, Transform target, float smoothTime, float angleModifier = 0)
	{
		LerpLookAt2D(who, target.transform.position, smoothTime, angleModifier);
	}

	public static void LerpLookAt2D(this Transform who, GameObject target, float smoothTime, float angleModifier = 0)
	{
		LerpLookAt2D(who, target.transform.position, smoothTime, angleModifier);
	}

	public static void LerpLookAt2D(this Transform who, Vector3 targetPos, float smoothTime, float angleModifier = 0)
	{
		Vector3 angle = ReturnLookAt2D(who, targetPos, angleModifier);
		who.eulerAngles = Vector3LerpAngle(who.eulerAngles, angle, smoothTime);
	}

	#endregion

	#region LookAt2D

	public static void LookAt2D(this Transform who, Vector2 point, float angleModifier = 0)
	{
		LookAt2D(who, (Vector3)point, angleModifier);
	}

	public static void LookAt2D(this Transform who, Transform target, float angleModifier = 0)
	{
		LookAt2D(who, target.position, angleModifier);
	}

	public static void LookAt2D(this Transform who, GameObject target, float angleModifier = 0)
	{
		LookAt2D(who, target.transform.position, angleModifier);
	}

	public static void LookAt2D(this Transform who, Vector3 targetPos, float angleModifier = 0)
	{
		Vector2 lookDir = new Vector2(targetPos.x, targetPos.y) - new Vector2(who.position.x, who.position.y);
		float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
		who.localEulerAngles = new Vector3(0, 0, angle + angleModifier);
	}

	public static Vector3 ReturnLookAt2D(Transform someOne, Vector3 _targetPos, float angleModifier = 0)
	{

		Vector2 lookDir = new Vector2(_targetPos.x, _targetPos.y) - new Vector2(someOne.position.x, someOne.position.y);
		float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
		someOne.localEulerAngles = new Vector3(0, 0, angle + angleModifier);

		return someOne.transform.eulerAngles;

	}


	#endregion

	public static void RevertDirection(this Transform who){

		Direction2D(who, 180f);
	}

	public static void Direction2D(this Transform who, float angleModifier = 0)
	{
		who.localEulerAngles = new Vector3(
			who.transform.localEulerAngles.x,
			who.transform.localEulerAngles.y,
			who.transform.localEulerAngles.z + angleModifier);

	}

	public static Vector3 Vector3LerpAngle(Vector3 what, Vector3 newWhat, float smoothTime)
	{
		what.x = Mathf.LerpAngle(what.x, newWhat.x, smoothTime);
		what.y = Mathf.LerpAngle(what.y, newWhat.y, smoothTime);
		what.z = Mathf.LerpAngle(what.z, newWhat.z, smoothTime);
		return what;
	}

	#region Teleport


	public static void Teleport(this Transform who, Vector2 toWhere)
	{
		Teleport(who, (Vector3)toWhere);
	}

	public static void Teleport(this Transform who, Transform toWhere)
	{
		Teleport(who, toWhere.transform.position);
	}

	public static void Teleport(this Transform who, GameObject toWhere)
	{
		Teleport(who, toWhere.transform.position);
	}


	public static void Teleport(this Transform who, Vector3 toWhere)
	{
		who.position = new Vector3(toWhere.x, toWhere.y, toWhere.z);
	}


	#endregion

	#region Move 

	public static void Move2d(this Transform who, Vector2 _position, float _speed)
	{
		Move(who, (Vector3)_position, _speed);
	}

	public static void Move(this Transform who, Vector3 _position, float _speed)
	{
		who.position = Vector3.MoveTowards(who.position, _position, _speed * Time.deltaTime);
	}

	#endregion




}



