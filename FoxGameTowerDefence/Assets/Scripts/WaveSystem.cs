using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveSystem : MonoBehaviour
{
	public GameObject prefabEnemy;

	public GameObject enemySpawner;

	public GameObject Wave1AnimObj;
	public GameObject Wave2AnimObj;
	public GameObject Wave3AnimObj;

	private int enemySpawnRateWave1 = 5;
	private int enemySpawnRateWave2 = 10;
	private int enemySpawnRateWave3 = 15;

	public TextMeshProUGUI maxWaves;
	public string  maxWavesNumber;

	public TextMeshProUGUI wave;

	private void Start()
	{
		StartCoroutine("Wave1");
		maxWaves.text = maxWavesNumber;
	}

	IEnumerator Wave1()
	{
		yield return new WaitForSeconds(1f);
		Wave1AnimObj.SetActive(true);
		wave.text = "1";
		yield return new WaitForSeconds(6f);
		for (int i = 0; i < enemySpawnRateWave1; i++)
		{
			Instantiate(prefabEnemy, new Vector3(305, 32, 778), Quaternion.identity);
		}
		yield return new WaitForSeconds(1f);
		StartCoroutine("Wave2");
	}

	IEnumerator Wave2()
	{
		yield return new WaitForSeconds(10f);
		Wave2AnimObj.SetActive(true);
		wave.text = "2";
		yield return new WaitForSeconds(6f);
		for (int i = 0; i < enemySpawnRateWave2; i++)
		{
			Instantiate(prefabEnemy);
			
			
		}
		yield return new WaitForSeconds(1f);
		StartCoroutine("Wave3");
	}

	IEnumerator Wave3()
	{
		yield return new WaitForSeconds(10f);
		Wave3AnimObj.SetActive(true);
		wave.text = "3";
		yield return new WaitForSeconds(6f);
		for (int i = 0; i < enemySpawnRateWave3; i++)
		{
			Instantiate(prefabEnemy);
		}
	}
}