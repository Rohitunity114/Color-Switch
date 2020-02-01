using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    public ScanFeder fader;
    public Button[] levelButtons;
   
    void Start()
    {
        int levelReched = PlayerPrefs.GetInt("LevelReched", 1);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if(i + 1 > levelReched)
            {
                levelButtons[i].interactable = false;
            }
        }
    }
   
    public void Select(string LevelName)
    {
        fader.FadeTo(LevelName);
    }
}
