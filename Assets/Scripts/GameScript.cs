using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameScript : MonoBehaviour
{
	public Button leftMove;
	public Button rightMove;

	// Use this for initialization
	void Start () {
		
		leftMove = leftMove.GetComponent<Button>();
		rightMove = rightMove.GetComponent<Button>();
	}

	public void NoPress(){
		leftMove.enabled = true;
		rightMove.enabled = true;
	}

	public void ExitGame(){
		Application.Quit();
	}

}