using UnityEngine;
using System.Collections;

public class EndGameControl : MonoBehaviour {

	public int fontSize;
	public int widthOffset;
	public int heightOffset;
	GameObject scoringSystem;
	private int score;
	public string hsName = "Enter Name Here";
	private int highScore;



	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt ("currentScore", 0);
		highScore = PlayerPrefs.GetInt ("highscore", 0);
		Debug.Log (score + "   " + highScore);

	}

	void OnGUI() {

		GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.button.fontSize = fontSize;
		GUI.Box (new Rect (710, 510, 500, 200), "Score: " + score + "\nHighscore: " + highScore + "\nLeader: " + PlayerPrefs.GetString("hsLeader", "None"));

		if (GUI.Button (new Rect (50, heightOffset, 600, 250), "Main Menu")) {
			Application.LoadLevel (0);
		}

		if (GUI.Button (new Rect (Screen.width - 650 - widthOffset, heightOffset, 600, 250), "Restart Game")) {
			Application.LoadLevel (1);
		}
		if(score > highScore){
			GUI.skin.textField.fontSize = 50;
			hsName = GUI.TextField(new Rect(710, 310, 500, 75), hsName, 25);
			PlayerPrefs.SetString ("hsLeader", hsName);
		}
	}
}
