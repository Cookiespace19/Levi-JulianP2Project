using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
	[SerializeField] int waypointIndex = 0;
	[SerializeField] int lastCheckpoint;

	public NavMeshAgent agent;
	public GameObject enemy;


	private void Awake()
	{
		agent = enemy.GetComponent<NavMeshAgent>();
	}


	private void Start()
	{
		NextPoint();
		lastCheckpoint = Waypoints.Instance.waypoints.Length;
	}


	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Waypoints")
		{
			if (waypointIndex < lastCheckpoint - 1)
			{
				waypointIndex++;
				NextPoint();
			}
			else
			{
				Destroy(gameObject);
			}
		}
	}


	private void NextPoint()
	{
		agent.SetDestination(Waypoints.Instance.waypoints[waypointIndex].transform.position);
	}
}