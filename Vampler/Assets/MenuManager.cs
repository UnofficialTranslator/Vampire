using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()//Go to level 1
    {
        SceneManager.LoadScene("Playable");
    }

    public void QuitGmame()//Close application
    {
        Application.Quit();
    }

    public void Credits()//Show who made it
    {
        SceneManager.LoadScene("Credits");
    }

    public void BacktoStart()//Go to main menu
    {
        SceneManager.LoadScene("Main Menu");
    }
}
