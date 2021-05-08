using UnityEngine;
using System.Collections;

public class OptionManager : MonoBehaviour {
    public GameObject Soff;
    public GameObject Son;

    public GameObject Moff;
    public GameObject Mon;

    void Start()
    {
        Son.SetActive(true);
        Mon.SetActive(true);


    }
   

    public void Sound_off()
    {

        Soff.SetActive(false);
        Son.SetActive(true);
    
        


    }
    public void Sound_on()
    {
        
        Son.SetActive(false);
        Soff.SetActive(true);

    }
    public void Music_off()
    {
        Moff.SetActive(false);
        Mon.SetActive(true);

    }
    public void Music_on()
    {
        Mon.SetActive(false);
        Moff.SetActive(true);

    }

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
	
	}
}
