using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {
    public string levelSelect;
    public string mainMenu;
    public GameObject pauseMenuCanvas ;
    public GameObject TTP;
   
 


	// Use this for initialization
	void Start () {

        Time.timeScale = 0;
       

    }
	
	// Update is called once per frame
	void Update () {

        
	
	}
    public void TaptoPlay()
    {
        Time.timeScale = 1;
        Destroy(TTP);
        SMScript.PlaySound("click");
    }
    
    public void Pause()
    {
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0;
        SMScript.PlaySound("click");

    }
    public void Resume()
    {
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1;
        
        SMScript.PlaySound("click");

    }
}
