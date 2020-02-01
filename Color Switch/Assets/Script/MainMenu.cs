using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public ScanFeder feder;
    public void PlayGame(string gameMenuName)
    {
        feder.FadeTo(gameMenuName);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
