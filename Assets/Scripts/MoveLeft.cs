using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour {

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
	}

	// Use this for initialization
	void Start () {
		fadeScr = GameObject.FindObjectOfType<ScreenFader> ();
	}

	// Update is called once per frame
	public void StartButtonPressed(){
		fast = true;
		body2d.velocity = velocity;

	}

	void Update(){
		//sr.transform.position = new Vector3 (sr.transform.position.x + .1f, sr.transform.position.y, sr.transform.position.z);
	}
}