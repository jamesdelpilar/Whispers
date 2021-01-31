using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("It Works!");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("It Works!");
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("It Works!");
    }

    public void MainMenuGame()
    {
        SceneManager.LoadScene("MainMenu");
        Debug.Log("It Works!");
    }

    public void DialogueGame()
    {
        SceneManager.LoadScene("Dialogue");
        Debug.Log("It Works!");
    }

}
