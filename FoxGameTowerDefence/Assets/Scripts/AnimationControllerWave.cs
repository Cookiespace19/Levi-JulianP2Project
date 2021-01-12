using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControllerWave : MonoBehaviour
{
	public GameObject TextWave1;
	public GameObject TextWave2;
	public GameObject TextWave3;

	public GameObject CubeWave1;
	public GameObject CubeWave2;
	public GameObject CubeWave3;

	public void TextEnableWave1()
	{
		TextWave1.SetActive(true);
	}

	public void TextDisableWave1()
	{
		TextWave1.SetActive(false);
		CubeWave1.SetActive(false);
	}

	public void TextEnableWave2()
	{
		TextWave2.SetActive(true);
	}

	public void TextDisableWave2()
	{
		TextWave2.SetActive(false);
		CubeWave2.SetActive(false);
	}

	public void TextEnableWave3()
	{
		TextWave3.SetActive(true);
	}

	public void TextDisableWave3()
	{
		TextWave3.SetActive(false);
		CubeWave3.SetActive(false);
	}
}
