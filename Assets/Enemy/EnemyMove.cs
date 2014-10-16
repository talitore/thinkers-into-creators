using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public float MoveSpeed = 5f;
	public float WaitTime = 2f;

	private GameObject player;

	private float TimeCreated;
	// Use this for initialization
	void Start () {
		TimeCreated = Time.time;
		if (!player) player = GameObject.FindWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time - TimeCreated > WaitTime) {
			transform.LookAt(player.transform.position);
			rigidbody.MovePosition(Vector3.MoveTowards(transform.position, player.transform.position, MoveSpeed*Time.deltaTime));
		}
	}
}
