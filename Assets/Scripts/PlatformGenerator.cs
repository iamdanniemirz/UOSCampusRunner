using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour {

	public GameObject theplatform;
	public Transform generationPoint;
	public float distanceBetween;

	private float platformWidth;

	// Use this for initialization
	void Start () {
        

		platformWidth = theplatform.GetComponent<BoxCollider2D> ().size.x;
	
	}
	
	// Update is called once per frame
	void Update () {

		if(transform.position.x < generationPoint.position.x)
		{
			transform.position = new Vector3 (transform.position.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);

			Instantiate (theplatform, transform.position, transform.rotation);
	
	}
}
}