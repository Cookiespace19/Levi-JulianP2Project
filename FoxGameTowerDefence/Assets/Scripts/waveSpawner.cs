using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class waveSpawner : MonoBehaviour
{
    public GameObject MMUI;
    public GameObject WaveCountDownTimer;

    public Transform enemyPrefab;

    public Transform SpawnPoint;

    public float timeBetweenWaves = 5f;
    private float countdown = 10f;

    public Text wavecountdownText;


    private int waveIndex = 0;

   
    
    void Update()
    {
        if (MMUI.active == false)
        {
            WaveCountDownTimer.SetActive(true);

            if (countdown <= 0f)
            {
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;


            }


            countdown -= Time.deltaTime;

            wavecountdownText.text = Mathf.Round(countdown).ToString();
        }
        else return;
    }
    IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(3f);
        }

    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, SpawnPoint.position, SpawnPoint.rotation);
    }

}
