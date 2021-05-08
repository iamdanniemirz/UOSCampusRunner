using UnityEngine;
using System.Collections;

public class UIControls2 : MonoBehaviour {

    public string LevelSelect = "LevelSelect1";
    public string LevelSelect2 = "LevelSelect2";
    public string LevelSelect3 = "LevelSelect3";
    public string LevelSelect4 = "LevelSelect4";
    public string MainMenu = "MainMenu";

   


	// Use this for initialization

    public void LS1()
    {

        
        Application.LoadLevel(LevelSelect);
        SMScript.PlaySound("click");
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();﻿



    }
    public void LS2()
    {
        Application.LoadLevel(LevelSelect2);
        SMScript.PlaySound("click");
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();﻿

    }
    public void LS3()
    {
        Application.LoadLevel(LevelSelect3);
        SMScript.PlaySound("click");
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();﻿

    }
    public void LS4()
    {
        Application.LoadLevel(LevelSelect4);
        SMScript.PlaySound("click");
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();﻿

    }

    public void Backmain()
    {
        Application.LoadLevel(MainMenu);
        SMScript.PlaySound("click");
        BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Play();﻿
        }

    






}
