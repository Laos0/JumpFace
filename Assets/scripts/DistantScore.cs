using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistantScore : MonoBehaviour {

	public GameObject face;
	public bool isGameOver;
	public Text scoreTxt;
	public int counter;
	public bool isMoving;
	public float curXPos;
	public float prevXPos;
	public float yPos;
	
	// Update is called once per frame
	void Start(){
		StartCoroutine("incrementScore");

	}

	void FixedUpdate(){
		if (curXPos > 0) {
			prevXPos = curXPos;
		}
		curXPos = face.transform.position.x;
		yPos = face.transform.position.y;
	}

	IEnumerator incrementScore(){

		while(!isGameOver) {
			counter++;
			scoreTxt.text = counter.ToString ();
			motionCheck ();
			checkGameOver ();
			yield return new WaitForSeconds(1);

		}

	}

	public void checkGameOver(){

		if (yPos < -10) {
			gameOver ();
		}
	}

	public void gameOver(){
		isGameOver = true;
		if (isGameOver == true) {
			quitGame ();
		}
	}

	public void motionCheck(){
		if (curXPos == prevXPos) {
			isMoving = false;
		}
	}

	public void quitGame(){
		Application.Quit ();
	}




}
