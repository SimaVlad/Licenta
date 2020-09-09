using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsPanel ;

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenSettingsMenu()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettingsMenu()
    {
        settingsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game");
        Application.Quit();
    }
}
