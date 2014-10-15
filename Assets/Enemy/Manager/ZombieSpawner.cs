using UnityEngine;
using System.Collections;

public class ZombieSpawner : MonoBehaviour {
	
	public float SpawnTimer = 2f;
	public GameObject zombie_prefab;
	public GameObject spawner1;
	public GameObject spawner2;

	private float lastSpawnTime;
	private int lastSpawnLoc = 2;

	// Use this for initialization
	void Start () {
		lastSpawnTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - lastSpawnTime > SpawnTimer) {
			lastSpawnTime = Time.time;
			Vector3 spawnPos;
			if (lastSpawnLoc == 2) {
				spawnPos = spawner1.transform.position;
				lastSpawnLoc = 1;
			} else {
				spawnPos = spawner2.transform.position;
				lastSpawnLoc = 2;
			}
			GameObject zombie = Instantiate(zombie_prefab, spawnPos, Quaternion.identity) as GameObject;
			zombie.GetComponent<Animator>().SetInteger("randomIdle",Random.Range (1,2));
			zombie.GetComponent<Animator>().SetInteger("randomMove",Random.Range (1,6));
			zombie.transform.Rotate(0,-90,0);
		}
	}
}
