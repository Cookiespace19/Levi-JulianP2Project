using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public static EnemyHealth Instance { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public float enemyHealth;
    public float enemyMaxHealth;

    public Slider slider;

    private void Start()
    {
        enemyHealth = enemyMaxHealth;
        slider.value = CalculateEnemyHealth();
    }

    private void Update()
    {
        slider.value = CalculateEnemyHealth();

        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }

        if(enemyHealth > enemyMaxHealth)
        {
            enemyHealth = enemyMaxHealth;
        }
    }

    float CalculateEnemyHealth()
    {
        return enemyHealth / enemyMaxHealth;
    }
}
