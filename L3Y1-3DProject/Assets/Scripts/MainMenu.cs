using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas main;
    public Canvas options;
    public Canvas sound;
    public AudioSource InGameSong;
    public AudioSource Song01;
    // Start is called before the first frame update
    void Start()
    {
        main.enabled = true;
        options.enabled = false;
        sound.enabled = false;
    }

    public void OnPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnOptions()
    {
        main.enabled = false;
        options.enabled = true;
        sound.enabled = false;
    }

    public void OnSound()
    {
        main.enabled = false;
        options.enabled = false;
        sound.enabled = true;
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnBackToMain()
    {
        main.enabled = true;
        options.enabled = false;
        sound.enabled = false;
    }

    public void OnSong01()
    {
        InGameSong.Play();
    }

    public void OnSong02()
    {
        Song01.Play();
    }
}
