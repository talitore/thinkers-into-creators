﻿using UnityEngine;
using System.Collections;

public class PlayerDamage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Enemy")
		{
			Debug.Log("Took damage!!");
		}
	}
}
