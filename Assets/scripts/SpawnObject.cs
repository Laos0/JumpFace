using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

	public Transform heroTrans;
	public GameObject[] obj;
	public List<GameObject> grounds;
	public GameObject container;

	// how fast objects spawn
	// spawn: the number of second it can random a prefab
	public float spawnMin = 10f; 
	public float spawnMax = 15f;





	// Use this for initialization
	void Start () {
		spawn ();
	}

	void spawn(){
		//grounds.Add(Instantiate(obj[Random.Range(0, obj.Length)], transform.position, Quaternion.identity));

		//GameObject tempObj = Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
		//tempObj.transform.SetParent (container.transform);

		Vector3 spawnPos = new Vector3 (heroTrans.position.x + 10, transform.position.y, 0);
			
		Instantiate (obj [Random.Range (0, obj.Length)], spawnPos, Quaternion.identity);


		// The function will call itself again after some random amount of time
		Invoke ("spawn", Random.Range (spawnMin, spawnMax));

		//Invoke ("clearGround", 3);
	}

	void clearGround(){
		Destroy (container);
	}
		
}
