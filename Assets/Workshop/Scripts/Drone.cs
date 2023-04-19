using UnityEngine;
using System.Collections;

// Needs AI Nav Mesh Agent
[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class Drone : MonoBehaviour {
	UnityEngine.AI.NavMeshAgent agent;
	// Tower location
	Transform tower;
	// Attack frequency
	public float ATTACK_TIME = 2;
	float attackTime = 0;
	// Maximum HP for the character
	public int MAX_HP = 3;
	[System.NonSerialized]
	// initialize variable hp
	public int hp = 0;

	// initialize attack distance to 1.
	public float ATTACK_DISTANCE = 1;
	// Use this for initialization
	void Start () {
		// find nav mesh agent component
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		// Set target to the object tagged 'Tower'
		tower = GameObject.Find("Tower").transform;
		// Go to the target
		agent.destination = tower.position;
		// Initial hp is Max
		hp = MAX_HP;
		// attacking freqency set as default
		attackTime = ATTACK_TIME;
	}

	void Update()
	{
		// If enemy is close to the target less than attack distance, start attack
		if(agent.remainingDistance <= ATTACK_DISTANCE)
		{
			attackTime += Time.deltaTime;
			if(attackTime > ATTACK_TIME)
			{
				attackTime = 0;
				// Add damage to Tower
				Tower.Instance.Damage();
			}
		}
	}
}
