using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject[] prefabs;
	public float delay = 1.0f;
	public bool active = true;
	// Use this for initialization
	void Start () {
		StartCoroutine(PrefabGenerator());
	}

	IEnumerator PrefabGenerator(){
		yield return new WaitForSeconds(delay);
		if(active){
			var newTransform = transform;

			Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform.position, Quaternion.identity);

		}
		StartCoroutine(PrefabGenerator());

	}

	// Update is called once per frame
	void Update () {

	}
}
