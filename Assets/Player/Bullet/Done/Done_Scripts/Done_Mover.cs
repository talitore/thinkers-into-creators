using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
	public float speed;
	public float bulletLife = 5f;
	private float startTime;
	void Start ()
	{
		rigidbody.velocity = transform.forward * speed;
		transform.Rotate(-15, 0, 0);
		startTime = Time.time;
	}

	void Update () {
		if (Time.time - startTime > bulletLife) {
			Destroy (gameObject);
		}
	}


}
