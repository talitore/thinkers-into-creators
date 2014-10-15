using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	public float MoveSpeed = 5f;
	public float WaitTime = 2f;

	private float TimeCreated;
	private bool startedMove = false;
	// Use this for initialization
	void Start () {
		TimeCreated = Time.time;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Time.time - TimeCreated > WaitTime) {
			startedMove = true;
			rigidbody.velocity = new Vector3(-MoveSpeed, 0, 0);
		}
	}
}
