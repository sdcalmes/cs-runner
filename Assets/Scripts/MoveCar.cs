using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveCar : MonoBehaviour {

	public Vector2 velocity = Vector2.zero;
	private Rigidbody2D body2d;
	private bool fast = false;

	ScreenFader fadeScr;
	public int SceneNumb = 1;

	void Awake(){
		body2d = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate(){
		if (!fast) {
			body2d.velocity = new Vector2 (1, 0);
		}

//		if (body2d.position.x > 100) {
//			body2d.velocity = new Vector2 (0, 0);
//		}
	}

	// Use this for initialization
	void Start () {
		fadeScr = GameObject.FindObjectOfType<ScreenFader> ();
		//Debug.Log (fadeScr);
	}
	
	// Update is called once per frame
	public void StartButtonPressed(){
		fast = true;
		body2d.velocity = velocity;

		//fadeScr.EndScene (0);
		//SceneManager.LoadScene(TestScene);
		Application.LoadLevel(1);
	}

	void Update(){
		//sr.transform.position = new Vector3 (sr.transform.position.x + .1f, sr.transform.position.y, sr.transform.position.z);
	}
}
