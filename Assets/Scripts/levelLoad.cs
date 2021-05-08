using UnityEngine;
using System.Collections;

public class SceneLoad : MonoBehaviour {
    public string levelToLoad;
    public string leveltag;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        LoadLevel();
	
	}
    public void LoadLevel()
    {
        PlayerPrefs.SetInt(leveltag, 1); 
    }
}
