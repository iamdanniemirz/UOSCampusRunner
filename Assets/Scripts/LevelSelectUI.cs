using UnityEngine;
using System.Collections;

public class LevelSelectUI : MonoBehaviour {
    public string level1;
    public string level2;
    public string level3;
    public string level4;

    public void lvl1()
    {
        Application.LoadLevel(level1);
    }
    public void lvl2()
    {
        Application.LoadLevel(level2);
    }
    public void lvl3()
    {
        Application.LoadLevel(level3);
    }
    public void lvl4()
    {
        Application.LoadLevel(level4);
    }
}
