using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [HeaderAttribute("Timer")]
    public float timer;
    public float timeLimit;
    public TMP_Text timertext;

    [HeaderAttribute("Collectables")]
    public int requiredCollectables;
    public int currentCollectables;
    public TMP_Text collectablesText;

    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        GameTimer();
        Collectables();
    }

    void GameTimer()
    {
        timertext.text = timer.ToString("F2");

        if (timer <= 0)
        {
            Debug.Log("Out of time");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
    void Collectables()
    {
        collectablesText.text = currentCollectables + " / " + requiredCollectables;
        if (currentCollectables == requiredCollectables)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
