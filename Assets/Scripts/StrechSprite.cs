using UnityEngine;
using System.Collections;

public class StrechSprite : MonoBehaviour {

	public int textureSize = 32;

	// Use this for initialization
	void Start () {
		var renderer = gameObject.GetComponent<Renderer>();
		float height = renderer.bounds.size.y;
		var newWidth = Mathf.Ceil(Screen.width / (textureSize * PixelPerfectCamera.scale));
		transform.localScale = new Vector3(newWidth * textureSize, height, 1);
		GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth, height, 1);


	}

	// Update is called once per frame
	void Update () {

	}
}
