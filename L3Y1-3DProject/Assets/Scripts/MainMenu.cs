using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas main;
    public Canvas sound;
    public AudioSource InGameSong;
    public AudioSource Song01;
    public AudioSource MainSong;
    public AudioSource WinSong;
    public GameObject Painting1;
    public GameObject Painting2;
    // Start is called before the first frame update
    void Start()
    {
        main.enabled = true;
        sound.enabled = false;
    }

    public void OnPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnSound()
    {
        main.enabled = false;
        sound.enabled = true;
        Painting1.SetActive(false);
        Painting2.SetActive(true);
        
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnBackToMain()
    {
        main.enabled = true;
        sound.enabled = false;
        MainSong.Stop();
        InGameSong.Stop();
        Song01.Stop();
        WinSong.Stop();
        MainSong.Play();
        Painting1.SetActive(true);
        Painting2.SetActive(false);
    }

    public void OnSong01()
    {
        MainSong.Stop();
        WinSong.Stop();
        Song01.Stop();
        InGameSong.Stop();
        InGameSong.Play();
    }

    public void OnSong02()
    {
        WinSong.Stop();
        MainSong.Stop();
        InGameSong.Stop();
        Song01.Stop();
        Song01.Play();
    }
    
    public void OnSong03()
    {
        WinSong.Stop();
        MainSong.Stop();
        InGameSong.Stop();
        Song01.Stop();
        MainSong.Play();
    }

    public void OnSong04()
    {
        WinSong.Stop();
        MainSong.Stop();
        InGameSong.Stop();
        Song01.Stop();
        WinSong.Play();
    }
}
