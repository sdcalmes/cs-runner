using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollisionDetection : MonoBehaviour {
	GameObject theScore;
	public AudioClip coinAudio;
	public AudioClip obstacleAudio;
	public bool gameOver;
	private int health = 3;
	SpriteRenderer sr;
	public GameObject[] hBar;

	void Start(){
		gameOver = false;
		theScore = GameObject.Find ("_ScoringSystem");
		//sr = hBar3.GetComponent<SpriteRenderer> ();

	}
	void OnTriggerEnter2D(Collider2D other){

		if (other.name.Equals ("coins(Clone)")) {
			//Debug.Log(other);
			Debug.Log("IN COINS " + gameObject.name);
			theScore.GetComponent<Scoring> ().score += 50;
			AudioSource CoinSound = gameObject.AddComponent<AudioSource> ();
			AudioSource.PlayClipAtPoint (coinAudio, transform.position);
			Destroy (other.gameObject);
		} else if (other.name.Equals ("obstacles(Clone)")) {
			//Debug.Log(other);
			AudioSource.PlayClipAtPoint (obstacleAudio, transform.position);
			Debug.Log (other.gameObject);
			health--;
			Destroy (hBar [health]);
			Destroy (other.gameObject);


		} else {
		}
		//Debug.Log (health);
//		Debug.Log (gameObject.name);
//		//Debug.Log("Collision detected with " + other.name);
//		if(other.name.Equals("Character")){
//			theScore.GetComponent<Scoring> ().score += 50;
//			if (isEndGame) {
//				Debug.Log ("END GAME! " + other);
//				Destroy (other.gameObject);
//				gameOver = true;
//				Application.LoadLevel (2);
//			} else {
//				Destroy (gameObject);
//			}
//		}
	}

	void Update(){
		if (health == 0) {
			gameOver = true;
			Application.LoadLevel (2);
		}
	}

	void OnTriggerStay2D(Collider2D other){
		//Debug.Log ("Still colliding");
	}

	void OnTriggerExit2D(Collider2D other){
		//Debug.Log ("Done colliding");
	}
}
