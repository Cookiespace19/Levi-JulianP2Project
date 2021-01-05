using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlacing : MonoBehaviour
{
	public GameObject MenuActive;
	public GameObject MenuInActive;
	[SerializeField] bool MenuIsActive = false;

    public GameObject Beer;
    public GameObject Hert;
    public GameObject Stekelvarken;
    public GameObject Wolf;

    bool PlayerInTrigger = false;

    private void Start()
	{
		MenuActive.active = MenuIsActive;
		MenuInActive.active = !MenuIsActive;
	}

    private void Update()
    {
        if (Input.GetButtonDown("TabMenu") && PlayerInTrigger == true)
        {
            print("MenuActive");
            MenuIsActive = !MenuIsActive;
            MenuActive.active = MenuIsActive;
            MenuInActive.active = !MenuIsActive;
        }

		if (Input.GetKeyDown(KeyCode.Z) && MenuIsActive == true)
		{
            Instantiate(Beer, transform.position, Quaternion.identity);
            MenuActive.active = !MenuIsActive;
            MenuInActive.active = MenuIsActive;
            MenuIsActive = !MenuIsActive;
            Destroy(gameObject);
		}
        if (Input.GetKeyDown(KeyCode.X) && MenuIsActive == true)
        {
            Instantiate(Hert, transform.position, Quaternion.identity);
            MenuActive.active = !MenuIsActive;
            MenuInActive.active = MenuIsActive;
            MenuIsActive = !MenuIsActive;
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.C) && MenuIsActive == true)
        {
            Instantiate(Stekelvarken, transform.position, Quaternion.identity);
            MenuActive.active = !MenuIsActive;
            MenuInActive.active = MenuIsActive;
            MenuIsActive = !MenuIsActive;
            Destroy(gameObject);
        }
        if (Input.GetKeyDown(KeyCode.V) && MenuIsActive == true)
        {
            Instantiate(Wolf, transform.position, Quaternion.identity);
            MenuActive.active = !MenuIsActive;
            MenuInActive.active = MenuIsActive;
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
                MenuActive.active = false;
                MenuInActive.active = true;
                MenuIsActive = false;
			}
        }
    }

    //Plaatsen van n totem, destroyed de empty en zet het menu false.
}
