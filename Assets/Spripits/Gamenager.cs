using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public float gamewidth = 40f;
    public int score = 0;
    public int droppedBalls = 0;
    public TMP_Text scoreText;
    public TMP_Text textFinal;
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    void Start()
    {
        scoreText.text = "Pontos:0";
        textFinal.text = " ";
        Time.timeScale = 1f;
        
    }
    public void AddScore(int Points=1)
    {
        score += Points;
        Debug.Log("Score: " + score);
        scoreText.text = "Pontos: "+score;
        if (score >= 30)
        {
            Debug.Log("ei cara, você ganhou o game, radical!");
            textFinal.text = "você venceu!";
            Time.timeScale = 0f;
        }
    }
    public void droppedballs()
    {
        droppedBalls++;
        Debug.Log("Dropped Balls: " + droppedBalls);
        if (droppedBalls >= 10)
        {
            Debug.Log("Game Over! VOCE MORREU, FAÇA UM PIX PARA O CPF 120.439.024-07");
            Time.timeScale = 0f;
        }
    }
}
