using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SMScript2 : MonoBehaviour {
    public static AudioClip mainMenu;
    static AudioSource audiosrc;
    public Toggle Sound;

	// Use this for initialization
    void Start()
    {
        mainMenu = Resources.Load<AudioClip>("mainmenu");
       
        if (AudioListener.pause)
        {
           Sound.isOn = true;
           AudioListener.pause = !AudioListener.pause;
        }



    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void off()
    {
        AudioListener.pause = !AudioListener.pause;
    }

   
   
}
