using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public Text scoreText;

    public GameObject gameOver;

    public static GameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    }

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string LevelName)
    {
        SceneManager.LoadScene(LevelName);
    }
    
    public void Abort()
    {
        Application.Quit();
    }

    void Update()
    {
        // Teclando ESC saira do Jogo, mas somente no executavel e nao dentro do editor
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
