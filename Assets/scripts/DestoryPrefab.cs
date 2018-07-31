using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryPrefab : MonoBehaviour {

	public GameObject prefab;

	void FixedUpdate(){

		Invoke ("destroyObj", 5);
	}

	void destoryObj(){
		Destroy (prefab);
	}
}
