using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalForChangeScene {

	public static Vector3 GlobalPosition{ get; private set;}
	private static bool IsGlobalPosition = false;

	public static void SetGlobalPosition(Vector3 tPosition)
	{
		GlobalPosition = tPosition;
	}

}