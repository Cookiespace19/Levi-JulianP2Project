using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControllerScript : MonoBehaviour
{
    public GameObject MenuActive;
    public GameObject MenuInActive;
    [SerializeField] bool menuActiveBool = false;

    public GameObject camera1;
    public GameObject camera2;
    [SerializeField] bool standardCamera = true;

    private void Start()
    {
        MenuActive.active = menuActiveBool;
        MenuInActive.active = !menuActiveBool;

        camera1.active = standardCamera;
        camera2.active = !standardCamera;
    }

    private void OnTriggerStay(Collider collision)
    {
        if(collision.tag == "Player")
        {
            if (Input.GetButtonDown("TabMenu"))
			{
                print("Tab");
                menuActiveBool = !menuActiveBool;
                MenuActive.active = menuActiveBool;
                MenuInActive.active = !menuActiveBool;
			}

            if (Input.GetButtonDown("CamChange"))
            {
                print("Camera");
                standardCamera = !standardCamera;
                camera1.active = standardCamera;
                camera2.active = !standardCamera;
            }
        }

        //als je op een button klikt van de controller, dan instantiate die een dier en sluit die het menu af. (Om een beer te spawnen moet het menu active zijn.)
    }
}
