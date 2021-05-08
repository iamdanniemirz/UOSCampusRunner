using UnityEngine;
using System.Collections;

public class LScript : MonoBehaviour {
    private AudioSource audiosrc3;
	// Use this for initialization
    void Start()
    {

        audiosrc3 = GetComponent<AudioSource>();
        audiosrc3.volume = PlayerPrefs.GetFloat("LurVol");
    }   
	
	// Update is called once per frame
	void Update () {
	
	}
}
