using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {
	public GameObject Bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetButtonDown("Fire1")) {
//			Input.GetKeyDown(KeyCode.Mouse1) == false;
			GameObject.Instantiate(Bullet, transform.position + transform.forward, transform.rotation); 
		}
	}
}
