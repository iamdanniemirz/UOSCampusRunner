using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class levelSelectManager : MonoBehaviour {
    public string levelToLoad;
    public string[] levelTags;
    public GameObject[] locks;
    public bool[] levelunlocked;
    

	// Use this for initialization
	void Start () {
        for (int i = 0; i < levelTags.Length; i++)
        {
            if (PlayerPrefs.GetInt(levelTags[i]) == null)
            {
                levelunlocked[i] = false;
            }
            else if (PlayerPrefs.GetInt(levelTags[i]) == 0)
            {
                levelunlocked[i] = false;
              
                
            }
            else
            {
                levelunlocked[i] = true;
            }

            if (levelunlocked[i])
            {
                locks[i].SetActive (false);
            }
        }
	}

    // Update is called once per frame
    void Update()
    {
        
	
	}
    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
  
}
