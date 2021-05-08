using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {

	public float speed = 0.5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Vector2 onset = new Vector2 (Time.fixedTime * speed, 0);

		GetComponent<Renderer> ().material.mainTextureOffset = onset;



	}
}
