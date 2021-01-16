using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacing : MonoBehaviour
{
    public GameObject TotemMenuUI;
	
	[SerializeField] bool MenuIsActive = false;

    public GameObject Beer;
    public GameObject Hert;
    public GameObject Stekelvarken;
    public GameObject Wolf;

    bool PlayerInTrigger = false;

   
    private void Start()
	{
        
        TotemMenuUI.SetActive(false);
		
	}

    private void Update()
    {
        

        if (Input.GetButtonDown("TabMenu") && PlayerInTrigger == true)
        {
            print("MenuActive");
            TotemMenuUI.SetActive(true);
            MenuIsActive = !MenuIsActive;
         
        }

        float LeftTrigger = Input.GetAxis("Left Trigger");

		if (LeftTrigger > 0 && MenuIsActive == true)
		{    
            print("dpad Left clicked");
            Instantiate(Beer, transform.position, Quaternion.identity);
            TotemMenuUI.SetActive(false);
            MenuIsActive = !MenuIsActive;
            Destroy(gameObject);
		}

        float RightTrigger = Input.GetAxis("Right Trigger");

        if (RightTrigger > 0 && MenuIsActive == true)
        {
            
            print("dpad Up clicked");
            Instantiate(Hert, transform.position, Quaternion.identity);
            TotemMenuUI.SetActive(false);
            MenuIsActive = !MenuIsActive;
            Destroy(gameObject);
            

            
        }

        if (Input.GetButtonDown("Right Button") && MenuIsActive == true)
        {
          
            print("dpad Right clicked");
            Instantiate(Stekelvarken, transform.position, Quaternion.identity);
            TotemMenuUI.SetActive(false);
            MenuIsActive = !MenuIsActive;
            Destroy(gameObject);
            

           
        }

        if (Input.GetButtonDown("Left Button") && MenuIsActive == true)
        {

            print("dpad Down clicked");
            Instantiate(Wolf, transform.position, Quaternion.identity);
            TotemMenuUI.SetActive(false);
            MenuIsActive = !MenuIsActive;
            Destroy(gameObject);
 
        }
      
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        if (other.tag == ("Player"))
        {
            PlayerInTrigger = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Exited");
        if (other.tag == ("Player"))
        {
            PlayerInTrigger = false;
            if(MenuIsActive == true)
			{
                TotemMenuUI.SetActive(false);
                MenuIsActive = false;
			}
        }
    }

    //Plaatsen van n totem, destroyed de empty en zet het menu false.
}
