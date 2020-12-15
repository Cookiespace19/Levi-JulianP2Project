using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponWheel : MonoBehaviour
{
    [SerializeField] private KeyCode wheelKey = KeyCode.Tab;
    [SerializeField] private GameObject wheelParent;

    //https://www.youtube.com/watch?v=G_oencTBtds&ab_channel=gameDevMode gebleven bij: 5:08

    public class Wheel
    {
        public Sprite highlightSprite;
        private Sprite m_NormalSprite;
        public Image wheel;

        public Sprite NormalSprite
        {
            get => m_NormalSprite;
            set => m_NormalSprite = value;
        }
    }

    [SerializeField] private Wheel[] wheels = new Wheel[4];

    private void EnableHighlight(int index)
    {
        for (int i = 0; i < wheels.Length; i++)
        {
            if (wheels[i].wheel != null && wheels[i].highlightSprite != null)
            {
                wheels[i].wheel.sprite = wheels[i].highlightSprite;
            }
        }
    }
    
    private void Start()
    {
        DisableWheel();
        for (int i = 0; i < wheels.Length; i++)
        {
            if(wheels[i].wheel != null)
            {
                wheels[i].NormalSprite = wheels[i].wheel.sprite;
            }
        }
    }

    private void EnableWheel()
    {
        if(wheelParent != null)
        {
            wheelParent.SetActive(true);
        }
    }

    private void DisableWheel()
    {
        if (wheelParent != null)
        {
            wheelParent.SetActive(false);
        }
    }
    
    private void Update()
    {
        if (Input.GetKey(wheelKey))
        {
            EnableWheel();
        }
        else if (Input.GetKeyUp(wheelKey))
        {
            DisableWheel();
        }
    }
}
