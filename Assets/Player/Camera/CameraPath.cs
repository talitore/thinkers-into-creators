using UnityEngine;
using System.Collections;

public class CameraPath : MonoBehaviour {

	public Transform player;
	public float MoveSpeed = 5f;

	private int currentPoint = 0;

	Vector3[] path = {
		new Vector3(7f,1f,10f),
		new Vector3(0f,1f,10f),
		new Vector3(1.5f,1f,-1f),
		new Vector3(0,1,-1),
		new Vector3(0,1,0)
	};

	// Use this for initialization
	void Start () {
		transform.localPosition = path[0];
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (currentPoint != 4) {
			transform.LookAt (new Vector3(0,1.5f,0));
			if ((path [currentPoint] - transform.localPosition).magnitude < .5f) {
						currentPoint += 1;
				}
			transform.localPosition = Vector3.Lerp (transform.localPosition, path [currentPoint], MoveSpeed * Time.deltaTime);
		} else {
			transform.LookAt (new Vector3(2,2,0));
			if ((path [currentPoint] - transform.localPosition).magnitude < .01f) {
				transform.localPosition = path[4];
				Destroy(this);
				}
			transform.localPosition = Vector3.Lerp (transform.localPosition, path [currentPoint], MoveSpeed * Time.deltaTime);
		}
	}
}
