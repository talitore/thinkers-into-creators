using UnityEngine;
using System.Collections;

public class Done_DestroyByContact : MonoBehaviour
{
	void Start ()
	{
	}

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Hit something");
		if (other.tag == "Enemy")
		{
			Debug.Log("Hit enemy!");
			return;
		}
	}
}