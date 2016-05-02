using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour {

	public static int score;
	public static int multiplier;
	public int fontSize;
	public int widthOffset;
	public int heightOffset;

	// Use this for initialization
	void Start () {
		score = 0;
		multiplier = 1;
		fontSize = 56;
		widthOffset = 100;
		heightOffset = 100;
		InvokeRepeating ("scoreIncrement", 1, 1);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI () {
		GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.button.fontSize = fontSize;
		GUI.Button (new Rect (0, 0, 250, 150), "Menu");
		GUI.Box (new Rect (250, 0, 500, 150), "Score: " + score + "\n" + "Multiplier: x" + multiplier);
		//GUI.Box (new Rect (0, 75, 500, 75), "Multiplier: " + multiplier);
		GUI.Button (new Rect (Screen.width - 475 - widthOffset, Screen.height - 100 - heightOffset, 250, 150), "Left");
		GUI.Button (new Rect (Screen.width - 200 - widthOffset, Screen.height - 100 - heightOffset, 250, 150), "Right");
	}

	void scoreIncrement () {
		score += 25 * multiplier;
	}
}
