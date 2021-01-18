﻿using UnityEngine;

public class Stekels : MonoBehaviour
{
	public EnemyHealth enemyhealth;
	private Transform target;

	public float speed;

	public float hitDamage = 20f;

	public void Seek(Transform _target)
	{
		target = _target;
	}

	private void Update()
	{
		if(target == null)
		{
			Destroy(gameObject);
			return;
		}

		Vector3 dir = target.position - transform.position;

		float distanceThisFrame = speed * Time.deltaTime;

		if(dir.magnitude <= distanceThisFrame)
		{
			HitTarget();
			return;
		}

		transform.Translate(dir.normalized * distanceThisFrame, Space.World);
	}

	void HitTarget()
	{

		enemyhealth.enemyHealth = enemyhealth.enemyHealth - hitDamage;
		Destroy(gameObject);
	}
}
