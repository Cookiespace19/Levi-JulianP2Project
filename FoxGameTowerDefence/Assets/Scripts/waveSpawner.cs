using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class waveSpawner : MonoBehaviour
{
    [Header("References")]
    public GameObject MMUI;
    public GameObject WaveCountDownTimer;
    public GameObject prefabEnemy;
    public Transform enemySpawner;

    [Header("Text")]
    public Text waveCountDownText;
    public TextMeshProUGUI maxWaves;
    public string maxWavesNumber;
    public TextMeshProUGUI wave;

    private float timeBetweenWaves = 5f;
    private float countdown = 10f;

    private int spawnRate;

	private void Start()
	{
        maxWaves.text = maxWavesNumber;
    }

	void Update()
    {
        if (MMUI.active == false)
        {
            StartWave();
        }

        if(spawnRate == 5)
		{
            StopCoroutine(SpawnWave());
            //load win screen
		}
    }

    private void StartWave()
	{
        WaveCountDownTimer.SetActive(true);

        countdown -= Time.deltaTime;

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
        }

        waveCountDownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {
        spawnRate++;
        for (int i = 0; i < spawnRate; i++)
        {
            Instantiate(prefabEnemy, enemySpawner.position, enemySpawner.rotation);
            wave.text = spawnRate.ToString();
            yield return new WaitForSeconds(0f);
        }
    }
}
