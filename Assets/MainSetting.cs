using UnityEngine;
using System.Collections;

public class MainSetting : MonoBehaviour {

	public static int score;
	public static int multiplier;
	public float fontSize;

	// Use this for initialization
	void Start () {
		score = 0;
		multiplier = 1;
		fontSize = Screen.width * (float) 0.075;
		InvokeRepeating ("scoreIncrement", 1, 1);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnGUI () {
		GUI.skin.label.fontSize = GUI.skin.button.fontSize = (int) fontSize;
		GUI.skin.box.fontSize = (int)(fontSize / 2);
		GUI.Button (new Rect (0, 0, Screen.width * (float) 0.2, Screen.height * (float) 0.2), "Menu");
//		GUIStyle scoreStyle = new GUIStyle ();
//		scoreStyle.fontSize = (int)(fontSize / 2);
		GUI.Box (new Rect (Screen.width * (float) 0.2, 0, Screen.width * (float) 0.4, Screen.height * (float) 0.15), "Score: " + score + "\n" + "Multiplier: x" + multiplier);
		//GUI.Box (new Rect (0, 75, 500, 75), "Multiplier: " + multiplier);
	}

	void scoreIncrement () {
		score += 25 * multiplier;
	}

}
