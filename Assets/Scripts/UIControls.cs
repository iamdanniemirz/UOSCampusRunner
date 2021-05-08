using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIControls : MonoBehaviour {

    
    

    public string level1tag = "level1lock";

    public string LevelSelect = "LevelSelect1" ;
    public string LevelSelect2 = "LevelSelect2";
    public string LevelSelect3 = "LevelSelect3";
    public string LevelSelect4 = "LevelSelect4";
    public string Help = "Help" ;
    public string Option = "Option";
    public string MainMenu = "MainMenu";
    public string Level1 = "Level 1";
    public string Level2 = "Level 2";
    public string Level3 = "Level 3";
    public string Level4 = "Level 4";
    public string Level5 = "Level 5";
    public string Level6 = "Level 6";
    public string Level7 = "Level 7";
    public string Level8 = "Level 8";
    public string Level9 = "Level 9";
    public string Level10 = "Level 10";
    public string Level11 = "Level 11";
    public string Level12 = "Level 12";
    public string Level13 = "Level 13";
    public string Level14 = "Level 14";
    public string Level15 = "Level 15";
    public string Level16 = "Level 16";
    public string Level17 = "Level 17";
    public string Level18 = "Level 18";
    public string Level19 = "Level 19";
    public string Level20 = "Level 20";

    public string Story1 = "Story1";
    public string Story2 = "Story2";
    public string Story3 = "Story3";
    public string Story4 = "Story4";




    public void SB1()
    {
        Application.LoadLevel(Story1);
        SMScript.PlaySound("click");

    }
    public void SB2()
    {
        Application.LoadLevel(Story2);
        SMScript.PlaySound("click");

    }
    public void SB3()
    {
        Application.LoadLevel(Story3);
        SMScript.PlaySound("click");

    }
    public void SB4()
    {
        Application.LoadLevel(Story4);
        SMScript.PlaySound("click");

    }

	public void PlayGame(){

        PlayerPrefs.SetInt(level1tag, 1);
		Application.LoadLevel(LevelSelect);
        SMScript.PlaySound("click");
        
        


}
    public void LS2()
    {
        Application.LoadLevel(LevelSelect2);
        SMScript.PlaySound("click");
       
    }
    public void LS3()
    {
        Application.LoadLevel(LevelSelect3);
        SMScript.PlaySound("click");
        
        
    }
    public void LS4()
    {
        Application.LoadLevel(LevelSelect4);
        SMScript.PlaySound("click");
       
        
    }
	public void QuitGame()
	{
		Application.Quit ();
        SMScript.PlaySound("click");
        
	}

	public void HelpGame( ){
		Application.LoadLevel(Help);
        SMScript.PlaySound("click");
	}
	public void OptionGame( ){
		Application.LoadLevel(Option);
        SMScript.PlaySound("click");
        
	}

	public void Backmain(){
		Application.LoadLevel (MainMenu);
        SMScript.PlaySound("click");
        
        
	}
    public void L1()
    {
        Application.LoadLevel(Level1);
        SMScript.PlaySound("click");
        
    }
    public void L2()
    {
        Application.LoadLevel(Level2);
        SMScript.PlaySound("click");
        
    }
    public void L3()
    {
        Application.LoadLevel(Level3);
        SMScript.PlaySound("click");
        
    }
    public void L4()
    {
        Application.LoadLevel(Level4);
        SMScript.PlaySound("click");
        
    }
    public void L5()
    {
        Application.LoadLevel(Level5);
        SMScript.PlaySound("click");
        
    }
    public void L6()
    {
        Application.LoadLevel(Level6);
        SMScript.PlaySound("click");
        
    }
    public void L7()
    {
        Application.LoadLevel(Level7);
        SMScript.PlaySound("click");
        
    }
    public void L8()
    {
        Application.LoadLevel(Level8);
        SMScript.PlaySound("click");
        
    }
    public void L9()
    {
        Application.LoadLevel(Level9);
        SMScript.PlaySound("click");
        
    }
    public void L10()
    {
        Application.LoadLevel(Level10);
        SMScript.PlaySound("click");
        
    }
    public void L11()
    {
        Application.LoadLevel(Level11);
        SMScript.PlaySound("click");
        
    }
    public void L12()
    {
        Application.LoadLevel(Level12);
        SMScript.PlaySound("click");
        
    }
    public void L13()
    {
        Application.LoadLevel(Level13);
        SMScript.PlaySound("click");
        
    }
    public void L14()
    {
        Application.LoadLevel(Level14);
        SMScript.PlaySound("click");
        
    }
    public void L15()
    {
        Application.LoadLevel(Level15);
        SMScript.PlaySound("click");
        
    }
    public void L16()
    {
        Application.LoadLevel(Level16);
        SMScript.PlaySound("click");
        
    }
    public void L17()
    {
        Application.LoadLevel(Level17);
        SMScript.PlaySound("click");
        
    }
    public void L18()
    {
        Application.LoadLevel(Level18);
        SMScript.PlaySound("click");
        
    }
    public void L19()
    {
        Application.LoadLevel(Level19);
        SMScript.PlaySound("click");
        
    }
    public void L20()
    {
        Application.LoadLevel(Level20);
        SMScript.PlaySound("click");
        
    }
		
}


