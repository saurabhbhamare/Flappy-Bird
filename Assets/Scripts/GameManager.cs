using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] private GameUI gameUI;
    [SerializeField] private Player player;

    private int score;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        Application.targetFrameRate = 60;
        Pause();
    }
    public void Play()
    {
        score = 0;
        Time.timeScale = 1;
        gameUI.UpdateScore(score);
        gameUI.HideGameOverScreen();
        gameUI.HidePlayButton();
        player.enabled = true;
        Pipes[] pipes = FindObjectsOfType<Pipes>();
        for(int i = 0; i< pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    public void Pause()
    {
        Time.timeScale = 0;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameUI.ShowGameOverScreen();
        gameUI.ShowPlayButton();
        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        gameUI.UpdateScore(score);
    }
}
