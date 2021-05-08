using UnityEngine;
using System.Collections;

public class LevelEnd : MonoBehaviour {
    //public string levelToLoad;
    //public string leveltag;
   

	// Use this for initialization
	void Start () {

       
       
	
	}
	
	// Update is called once per frame
	void Update () {

        LoadLevel();
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //LoadLevel();

           
            
        }
       
    }
    public void LoadLevel()
    {
        //PlayerPrefs.SetInt(leveltag, 1);

        
    }
}
