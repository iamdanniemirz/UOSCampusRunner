using UnityEngine;
using System.Collections;

public class SMScript : MonoBehaviour {

    public static AudioClip uiclick , playerjump , coin , levelComplete , levelFail;
     static AudioSource audiosrc2;

     

	// Use this for initialization
	void Start () {

        audiosrc2 = GetComponent<AudioSource>();
        audiosrc2.volume = PlayerPrefs.GetFloat("SurVol");

        uiclick = Resources.Load<AudioClip>("click");
        playerjump = Resources.Load<AudioClip>("jump");
        coin = Resources.Load<AudioClip>("coins");
        levelComplete = Resources.Load<AudioClip>("levelcomplete");
        levelFail = Resources.Load<AudioClip>("levelfail");

       
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "click" :
                audiosrc2.PlayOneShot(uiclick);
                break;
            case "jump":
                audiosrc2.PlayOneShot(playerjump);
                break;
            case "coins":
                audiosrc2.PlayOneShot(coin);
                break;
            case "levelcomplete":
                audiosrc2.PlayOneShot(levelComplete);
                break;
            case "levelfail":
                audiosrc2.PlayOneShot(levelFail);
                break;
        }
    }

 
    }
    

    

   

      
 
   

    
    

