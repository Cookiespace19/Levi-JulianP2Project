using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerControllerScript : MonoBehaviour
{
    public GameObject Player;

    public GameObject camera1;
    public GameObject camera2;
    [SerializeField] bool standardCamera = true;

    public Transform TPOne;
    public Transform TPTwo;
    public Transform TPThree;
    public Transform TPFour;
    public Transform TPFive;

    public GameObject TP_UI;

    private void Start()
    {

        camera1.active = standardCamera;
        camera2.active = !standardCamera;
    }

    private void OnTriggerStay(Collider collision)
    {
        if(collision.tag == "Player")
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Camera");
                standardCamera = !standardCamera;
                camera1.active = standardCamera;
                camera2.active = !standardCamera;
            }
        }

        //als je op een button klikt van de controller, dan instantiate die een dier en sluit die het menu af. (Om een beer te spawnen moet het menu active zijn.)
    }

    public void Update()
    {

        if (camera1.active)
        {
            TP_UI.SetActive(false);
            Player.GetComponent<playerMovement>().enabled = true;
        }

        if (camera2.active)
        {
            TP_UI.SetActive(true);
            Player.GetComponent<playerMovement>().enabled = false;
        }
    }


    void TP1()
    {
        Player.transform.position = TPOne.transform.position;
    }
    void TP2()
    {
        Player.transform.position = TPTwo.transform.position;
    }
    void TP3()
    {
        Player.transform.position = TPThree.transform.position;
    }
    void TP4()
    {
        Player.transform.position = TPFour.transform.position;
    }
    void TP5()
    {
        Player.transform.position = TPFive.transform.position;
    }
}
