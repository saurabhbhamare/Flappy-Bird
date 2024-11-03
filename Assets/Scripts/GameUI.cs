using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameUI : MonoBehaviour
{
    public Button playButton;
    public Image gameOverImage;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        gameOverImage.gameObject.SetActive(false);
    }
    public void UpdateScore(int score)
    {
        scoreText.text = score.ToString();
    }
    public void ShowGameOverScreen()
    {
        gameOverImage.gameObject.SetActive(true);
    }
    public void HideGameOverScreen()
    {
        gameOverImage.gameObject.SetActive(false);
    }
    public void HidePlayButton()
    {
        playButton.gameObject.SetActive(false);
    }
    public void ShowPlayButton()
    {
        playButton.gameObject.SetActive(true);
    }
}
