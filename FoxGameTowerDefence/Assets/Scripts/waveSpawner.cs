using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class waveSpawner : MonoBehaviour
{
    [Header("References")]
    public GameObject MMUI;
    public GameObject WaveText;
    public GameObject WaveCountDownTimer;
    public GameObject prefabEnemy;
    public Transform enemySpawner;

    [Header("Text")]
    public Text waveCountDownText;
    public TextMeshProUGUI wave;

    [Header("Time setting")]
    public float timeBetweenWaves;
    private float countdown = 10f;

    private int waveIndex = 0;

	void Update()
    {
        if (MMUI.active == false)
        {
            WaveCountDownTimer.SetActive(true);
            WaveText.SetActive(true);

            countdown -= Time.deltaTime;

            if (countdown <= 0f)
            {
                StartCoroutine(SpawnWave());
                countdown = timeBetweenWaves;
            }

            waveCountDownText.text = Mathf.Round(countdown).ToString();
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
        Instantiate(prefabEnemy, enemySpawner.position, enemySpawner.rotation);
        wave.text = waveIndex.ToString();
    }
}
