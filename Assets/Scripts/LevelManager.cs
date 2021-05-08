using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {
    public int coinCount;
    public Text cointext;
    public Text completetext;
    public int highCount;
    public Toggle Sound;
  
    

	// Use this for initialization
	void Start () {
        cointext.text = "Score: " + coinCount;
        completetext.text = "Sore: " + coinCount;

        


        
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddCoins(int coinsToAdd)
    {
        coinCount = coinCount + coinsToAdd;
        
        

        cointext.text = "SCORE   " + coinCount;
        completetext.text = "SCORE   " + coinCount;
        
        if (coinCount >= highCount)
        {
            highCount = coinCount;

           
            PlayerPrefs.SetInt("highCount", highCount);
        }
    }
}
