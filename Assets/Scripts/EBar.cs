using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EBar : MonoBehaviour {
    [SerializeField]
    private float fillAmount;
   
    [SerializeField]
    private Image content;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Handlebar();
	}

    private void Handlebar()
    {
        float i = fillAmount;
        for ( i = 1; i >= 1; i--)
        {
            fillAmount = i;
        }
        
    }

   
}
