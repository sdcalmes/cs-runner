using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button exitText;
	public Button settingsText;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas>();
		startText = startText.GetComponent<Button>();
		exitText = exitText.GetComponent<Button>();
		settingsText = settingsText.GetComponent<Button>();
		quitMenu.enabled = false;
	}

	public void ExitPress(){
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
		settingsText.enabled = false;
	}

	public void NoPress(){
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
		settingsText.enabled = true;
	}

	public void StartLevel(){
		//make the car drive off
		//Application.LoadLevel(1);
	}

	public void ExitGame(){
		Application.Quit();
	}

}
