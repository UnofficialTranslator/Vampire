using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip click;

    private void Start()
    {
        source.clip = click;
    }
    public void StartGame()//Go to level 1
    {
        source.Play();
        SceneManager.LoadScene("Playable");
    }

    public void QuitGmame()//Close application
    {
        source.Play();
        Application.Quit();
    }

    public void Credits()//Show who made it
    {
        source.Play();
        SceneManager.LoadScene("Credits");
    }

    public void BacktoStart()//Go to main menu
    {
        source.Play();
        SceneManager.LoadScene("Main Menu");
    }
}
