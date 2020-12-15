using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
	public GameObject camera1;
	public GameObject camera2;
	bool standardCamera = true;

	private void  Start()
	{
		camera1.active = standardCamera;
		camera2.active = !standardCamera;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			standardCamera = !standardCamera;
			camera1.active = standardCamera;
			camera2.active = !standardCamera;
		}
	}
}
