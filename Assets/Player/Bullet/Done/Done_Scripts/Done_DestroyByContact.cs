using UnityEngine;
using System.Collections;

public class Done_DestroyByContact : MonoBehaviour
{
	public GameObject enemyExplosion;
	void Start ()
	{
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Enemy")
		{
			Instantiate(enemyExplosion, other.transform.position, Quaternion.identity);
			Destroy(other.gameObject);
		}
	}
}