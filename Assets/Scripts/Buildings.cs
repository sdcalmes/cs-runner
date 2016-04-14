using UnityEngine;
using System.Collections;

public class Buildings : MonoBehaviour {

	public Sprite[] sprites;
	// Use this for initialization
	void Start () {
		var renderer = GetComponent<SpriteRenderer>();
		renderer.sprite = sprites[Random.Range(0, sprites.Length)];
	}

	// Update is called once per frame
	void Update () {

	}
}
