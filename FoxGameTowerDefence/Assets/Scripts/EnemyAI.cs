using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
	public float speed;
	private Waypoints Wpoints;

	private int waypointIndex;

	private void Start()
	{
		Wpoints = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
	}

	private void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, Wpoints.waypoints[waypointIndex].position, speed * Time.deltaTime);

		Vector3 dir = Wpoints.waypoints[waypointIndex].position - transform.position;
		float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

		if (Vector3.Distance(transform.position, Wpoints.waypoints[waypointIndex].position) < 0.1f)
		{
			if(waypointIndex < Wpoints.waypoints.Length - 1)
			{
				waypointIndex++;
			}
			else
			{
				Destroy(gameObject);
			}
		}
	}
}
