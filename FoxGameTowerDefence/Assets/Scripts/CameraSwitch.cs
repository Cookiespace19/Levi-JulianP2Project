using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
	public GameObject camera1;
	public GameObject camera2;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			camera1.SetActive(false);
			camera2.SetActive(true);
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			camera1.SetActive(true);
			camera2.SetActive(false);
		}
	}
}
