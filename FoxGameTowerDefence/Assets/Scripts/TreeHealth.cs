using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeHealth : MonoBehaviour
{
    public static TreeHealth Instance { get; private set; }
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

    public float treeHealth;
    public float treeMaxHealth;

    public Slider slider;

    private void Start()
    {
        treeHealth = treeMaxHealth;
        slider.value = CalculateTreeHealth();
    }

    private void Update()
    {
        slider.value = CalculateTreeHealth();

        if (treeHealth <= 0)
        {
            Destroy(gameObject);
        }

        if (treeHealth > treeMaxHealth)
        {
            treeHealth = treeMaxHealth;
        }
    }

    float CalculateTreeHealth()
    {
        return treeHealth / treeMaxHealth;
    }
}
