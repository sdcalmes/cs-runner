using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	Vector3 initialPosition;
	public int widthOffset;
	public int heightOffset;
	public float fontSize;
	float currX;
	float currY;
	float currZ;
	GameObject initial;
	// Use this for initialization
	void Start () {
		fontSize = Screen.width * (float) 0.075;
		widthOffset = 100;
		heightOffset = 100;
		initial = gameObject;
		initialPosition = gameObject.transform.position;
		currX = initialPosition.x;
		currY = initialPosition.y;
		currZ = initialPosition.z;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI () {
		GUI.skin.label.fontSize = GUI.skin.box.fontSize = GUI.skin.button.fontSize = (int) fontSize;
		if (GUI.Button (new Rect (Screen.width * (float) 0.55, Screen.height * (float) 0.75, Screen.width * (float) 0.2, Screen.height * (float) 0.25), "Left")) {
			Vector3 pos = transform.position;
			//print (currX + " > " + initialPosition.x);
			if (currX > initialPosition.x) {
				pos.x = currX;
				pos.y = currY;
				pos.z = currZ;
			} else {
				pos.x = initialPosition.x;
				pos.y = initialPosition.y;
				pos.z = initialPosition.z;
			}
			gameObject.transform.position = pos;
			gameObject.transform.Translate (-0.75f, 0.40f, 0, Space.Self);
			currX = gameObject.transform.position.x;
			currY = gameObject.transform.position.y;
			currZ = gameObject.transform.position.z;
		}

		if (GUI.Button (new Rect (Screen.width * (float) 0.775, Screen.height * (float) 0.75, Screen.width * (float) 0.2, Screen.height * (float) 0.25), "Right")) {
			Vector3 pos = transform.position;
			//print (currX + " < " + initialPosition.x);
			if (currX < initialPosition.x) {
				pos.x = currX;
				pos.y = currY;
				pos.z = currZ;
			} else {
				pos.x = initialPosition.x;
				pos.y = initialPosition.y;
				pos.z = initialPosition.z;
			}
			gameObject.transform.position = pos;
			gameObject.transform.Translate (0.75f, -0.40f, 0, Space.Self);
			currX = gameObject.transform.position.x;
			currY = gameObject.transform.position.y;
			currZ = gameObject.transform.position.z;
		}
	}
}
