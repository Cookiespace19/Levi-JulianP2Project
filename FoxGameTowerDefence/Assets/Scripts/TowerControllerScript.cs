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

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == "Player")
        {
            triggerStay = true;
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        triggerStay = false;
    }

    bool triggerStay = false;

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

        if (Input.GetKeyDown(KeyCode.E) && triggerStay == true) 
        {
                print("Camera");
                standardCamera = !standardCamera;
                camera1.active = standardCamera;
                camera2.active = !standardCamera;
        }
        
    }


    public void TP1()
    {
        Player.transform.position = TPOne.transform.position;
        TP_UI.SetActive(false);
        Player.GetComponent<playerMovement>().enabled = true;
        camera1.active = standardCamera;
    }
    public void TP2()
    {
        Player.transform.position = TPTwo.transform.position;
        TP_UI.SetActive(false);
        Player.GetComponent<playerMovement>().enabled = true;
        camera1.active = standardCamera;
        
    }
    public void TP3()
    {
        Player.transform.position = TPThree.transform.position;
        TP_UI.SetActive(false);
        Player.GetComponent<playerMovement>().enabled = true;
        camera1.active = standardCamera;
    }
    public void TP4()
    {
        Player.transform.position = TPFour.transform.position;
        TP_UI.SetActive(false);
        Player.GetComponent<playerMovement>().enabled = true;
        camera1.active = standardCamera;
    }
    public void TP5()
    {
        Player.transform.position = TPFive.transform.position;
        TP_UI.SetActive(false);
        Player.GetComponent<playerMovement>().enabled = true;
        camera1.active = standardCamera;
    }
}
