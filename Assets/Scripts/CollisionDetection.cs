using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollisionDetection : MonoBehaviour {
	GameObject theScore;
	public bool isEndGame = false;
	public bool gameOver;
	void Start(){
		gameOver = false;
		theScore = GameObject.Find ("_ScoringSystem");
	}
	void OnTriggerEnter2D(Collider2D other){
		//Debug.Log("Collision detected with " + other.name);
		if(other.name.Equals("Character")){
			theScore.GetComponent<Scoring> ().score += 50;
			if (isEndGame) {
				Debug.Log ("END GAME! " + other);
				Destroy (other.gameObject);
				gameOver = true;
			} else {
				Destroy (gameObject);
			}
		}
	}

	void OnTriggerStay2D(Collider2D other){
		//Debug.Log ("Still colliding");
	}

	void OnTriggerExit2D(Collider2D other){
		//Debug.Log ("Done colliding");
	}
}
