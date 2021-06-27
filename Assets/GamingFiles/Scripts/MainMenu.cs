using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private int sceneToContinue;

    private void Start()
    {
        if (GameObject.Find("Continue") == null)
        {
            return;
        }

        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        if (sceneToContinue != 0)
        {
            GameObject.Find("Continue").SetActive(true);
            GameObject.Find("Play").SetActive(false);
        } else
        {
            GameObject.Find("Continue").SetActive(false);
            GameObject.Find("Play").SetActive(true);
        }
    }

    public void ContinueGame()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        if (sceneToContinue != 0)
        {
            SceneManager.LoadScene(sceneToContinue);
        } else
        {
            return;
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
