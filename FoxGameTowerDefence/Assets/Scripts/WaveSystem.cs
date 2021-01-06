using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
	public GameObject prefabEnemy;

	private int enemySpawnRate = 5;

	private void Start()
	{
		for (int i = 0; i < enemySpawnRate; i++)
		{
			Instantiate(prefabEnemy);
		}
	}
}