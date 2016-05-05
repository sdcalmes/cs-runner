using UnityEngine;
using System.Collections;

public class EndGameControl : MonoBehaviour {

	public int fontSize;
	public int widthOffset;
	public int heightOffset;
	GameObject scoringSystem;
	private int score;
	private int highScore;



	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("currentScore", 0);
		highScore = PlayerPrefs.GetInt ("highscore", 0);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {
		GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.button.fontSize = fontSize;
		GUI.Box (new Rect (750, 510, 400, 100), "Score: " + score + "\nHighscore: " + highScore);

		if (GUI.Button (new Rect (50, Screen.height - heightOffset, 600, 250), "Main Menu")) {
			Application.LoadLevel (0);
		}

		if (GUI.Button (new Rect (Screen.width - 650 - widthOffset, Screen.height - heightOffset, 600, 250), "Restart Game")) {
			Application.LoadLevel (1);
		}
	}
}
