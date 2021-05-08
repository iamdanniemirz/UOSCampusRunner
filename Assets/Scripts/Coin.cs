using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
    private LevelManager theLevelmanager;
    public int coinValue;
   

	// Use this for initialization
	void Start () {
        theLevelmanager = FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            theLevelmanager.AddCoins(coinValue);
            Destroy(gameObject);
            SMScript.PlaySound("coins");
    }
        
    }
}
