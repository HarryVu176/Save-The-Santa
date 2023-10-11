using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOver;
    public GameObject playButton;
    public int score { get; private set; }

    private Player player;
    private Enemy enemy;

    private void Awake()
    {
        Pause();
        score = 0;
        scoreText.text = score.ToString();
        Application.targetFrameRate = 60;
        player = FindObjectOfType<Player>();
        enemy = FindObjectOfType<Enemy>();
        
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;

        player.enabled = true;

    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        
        Debug.Log("Game Over");
        playButton.SetActive(true);
        Time.timeScale = 0f;
        player.enabled = false;
        //enemy.Reset();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    
}
