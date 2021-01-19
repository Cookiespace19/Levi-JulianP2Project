using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Forcefield : MonoBehaviour
{
	EnemyHealth eHealth;

	NavMeshAgent agent;

	private void Start()
	{
		eHealth = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyHealth>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Enemy")
		{
			StartCoroutine(DamageOverTime());
			agent = waveSpawner.Instance.newGO.GetComponent<NavMeshAgent>();
			agent.speed = 3.5f;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.tag == "Enemy")
		{
			agent.speed = 7f;
			StopAllCoroutines();
		}
	}

	IEnumerator DamageOverTime()
	{
		yield return new WaitForSeconds(1f);
		StartCoroutine(DamageOverTime());
		eHealth.HitTargetHert();
	}
}
