using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MScript3 : MonoBehaviour
{

    public AudioSource audiosrc;

    public AudioSource audiosrc2;

    public AudioSource audiosrc3;

    public Slider mslider;
    public Slider sslider;
    
   
    
    


    public void Awake()
    {

        audiosrc = GameObject.FindGameObjectWithTag("MainMusic").GetComponent<AudioSource>();
        audiosrc2 = GameObject.FindGameObjectWithTag("MainSound").GetComponent<AudioSource>();
        audiosrc3 = GameObject.FindGameObjectWithTag("MainLevelMusic").GetComponent<AudioSource>();

        audiosrc3.volume = PlayerPrefs.GetFloat("LurVol");
        mslider.value = audiosrc3.volume;
        
        

        audiosrc2.volume = PlayerPrefs.GetFloat("SurVol");
        sslider.value = audiosrc2.volume;
        

        audiosrc.volume = PlayerPrefs.GetFloat("CurVol");
        mslider.value = audiosrc.volume;
       
        
        //BGSoundScript.Instance.gameObject.GetComponent<AudioSource>().Pause();﻿
       
           
    }
  
    public void MusicControl(float musicControl)
    {
        audiosrc.volume = musicControl;
        PlayerPrefs.SetFloat("CurVol",audiosrc.volume);
    }

    public void SoundControl(float soundControl)
    {
        audiosrc2.volume = soundControl;
        PlayerPrefs.SetFloat("SurVol", audiosrc2.volume);
    }
    public void LevelControl(float levelControl)
    {
        audiosrc3.volume = levelControl;
        PlayerPrefs.SetFloat("LurVol", audiosrc3.volume);
    }
}
    

