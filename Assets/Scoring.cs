using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour {

	public int score;
	public static int lane;
	public static int multiplier;
	public int fontSize;
	public int widthOffset;
	public int heightOffset;
	GameObject thePlayer;
	GameObject endGameDetect;
	int oldHighScore;
	int newHighScore;
	bool gOver;

	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		score = 25;
		multiplier = 1;
		lane = 1;
		fontSize = 56;
		widthOffset = 100;
		heightOffset = 100;
		InvokeRepeating ("scoreIncrement", 1, 1);
		oldHighScore = PlayerPrefs.GetInt ("highscore", 0);
		endGameDetect = GameObject.Find ("EndGameCollider");
		thePlayer = GameObject.Find ("Character");
		sr = thePlayer.GetComponent<SpriteRenderer> ();

	}

	// Update is called once per frame
	void Update () {
		gOver = endGameDetect.GetComponent<CollisionDetection>().gameOver;
		if (score > oldHighScore) {
			newHighScore = score;
		}
		if (gOver)
			GameOver ();
	}

	void OnGUI () {
		//Debug.Log (gOver);
		if (!gOver) {
			var playerPos = thePlayer.transform.position;
			Vector3 moveLeft = new Vector3 (-.5f, .5f, 0);
			Vector3 moveRight = new Vector3 (.5f, -.5f, 0);
			GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.button.fontSize = fontSize;
			GUI.Box (new Rect (0, 0, 500, 225), "Score: " + score + "\n" + "Multiplier: x" + multiplier + "\n" + "Highscore: " + oldHighScore);
			//GUI.Box (new Rect (0, 75, 500, 75), "Multiplier: " + multiplier);
			if (GUI.Button (new Rect (Screen.width - 425 - widthOffset, Screen.height - 100 - heightOffset, 250, 150), "Left")) {
				Debug.Log ("You clicked left");
				if (lane > 0) {
					thePlayer.transform.position = playerPos + moveLeft;
					lane--;
				}
			}
			if (GUI.Button (new Rect (Screen.width - 175 - widthOffset, Screen.height - 100 - heightOffset, 250, 150), "Right")) {
				;
				Debug.Log ("You clicked right");
				if (lane < 2) {
					thePlayer.transform.position = playerPos + moveRight;
					lane++;
				}

			}
		} else {
			GUI.Box (new Rect (0, 0, 600, 150), "Game Over!\n" + "Your score was " + score);
			if (GUI.Button (new Rect (Screen.width - 250 - widthOffset, Screen.height - 100 - heightOffset, 300, 150), "Start Over")) {
				Application.LoadLevel(0);
	
			}
		}
			
	}

	void scoreIncrement () {
		if (!gOver) {
			score += 25 * multiplier;
		}
	}

	void GameOver(){
		if (score > oldHighScore) {
			PlayerPrefs.SetInt ("highscore", score);
		}
	}

}
