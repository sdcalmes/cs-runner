using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] prefabs;
	public float delay = 1.0f;
	public bool active = true;
	public bool isCoin = false;
	public bool isObstacle = false;
	private bool gOver;
	private static Random rnd = new Random();
	GameObject theScore;
	GameObject endGameDetect;

	private float[] coinPositions = {-.75f, 0f, .75f};
	private Vector3 resetCoin = new Vector3 (-5.97f, -3.4f, 0);
	private Vector3 resetObstacle = new Vector3 (-5.97f, -3.3f, 0);

	// Use this for initialization
	void Start () {
		theScore = GameObject.Find ("_ScoringSystem");
		endGameDetect = GameObject.Find ("EndGameCollider");
		StartCoroutine(PrefabGenerator());
	}

	IEnumerator PrefabGenerator(){
		yield return new WaitForSeconds(delay);
		if(active){
			var newTransform = transform;
			var coinTransform = transform;
			Vector3 newTrans = transform.position;
			float r = coinPositions [Random.Range (0, coinPositions.Length)];
			newTrans.y = newTrans.y + r;
			if (!isCoin && !isObstacle) {
				Instantiate (prefabs [Random.Range (0, prefabs.Length)], newTransform.position, Quaternion.identity);
			} else {
				coinTransform.position = newTrans;
				Instantiate (prefabs [Random.Range (0, prefabs.Length)], coinTransform.position, Quaternion.identity);
			}
			if(isCoin)
				coinTransform.position = resetCoin;
			if (isObstacle)
				coinTransform.position = resetObstacle;

		}
		StartCoroutine(PrefabGenerator());

	}

	// Update is called once per frame
	void Update () {
		if(isCoin || isObstacle)
			gOver = endGameDetect.GetComponent<CollisionDetection>().gameOver;
		if (gOver) {
			active = false;
		}
		if (isObstacle) {
			if ((theScore.GetComponent<Scoring> ().score % 250) == 0) {
				if (delay > .5f) {
					Debug.Log ("Lowering Delay!");
					theScore.GetComponent<Scoring> ().score += 25;
					delay -= .2f;
				}
			}
		}
	}
}
