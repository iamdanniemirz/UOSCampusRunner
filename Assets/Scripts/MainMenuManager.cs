using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour {
    public int highScore;
    public Text highText;

	// Use this for initialization
	void Start () {
        highScore = PlayerPrefs.GetInt("highCount", 0);
        
	
	}
	
	// Update is called once per frame
	void Update () {
        highText.text = "HighScore : " + highScore;
        
	
	}
}
