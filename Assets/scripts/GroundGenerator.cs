using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour {
	public GameObject prefab;
	public Transform face;
	public GameObject container;
	public List<GameObject> grounds;

	// Use this for initialization
	void Start () {
		grounds = new List<GameObject> ();
		generate ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.A)) {
			generate ();
		}
	}

	void generate(){
//		GameObject tempGround = Instantiate (prefab);
//		//tempGround.transform.transform.position.Set (0, -2, 0);
//
//
//		tempGround.transform.SetParent (container.transform);
//		tempGround.transform.position.Set (0, -2, 0);
//
//		grounds.Add(tempGround);


	}
		
}
