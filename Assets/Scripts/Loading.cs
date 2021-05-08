using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {
    public float LoadingTime;
    public Image LoadingBar;
    public string Level;

	// Use this for initialization
	void Start () {
        LoadingBar.fillAmount = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (LoadingBar.fillAmount <= 1) { 
        LoadingBar.fillAmount += 1.0f / LoadingTime * Time.deltaTime;
    }
        if (LoadingBar.fillAmount == 1.0f)
        {
            Application.LoadLevel(Level);
        }
	
	}
}
