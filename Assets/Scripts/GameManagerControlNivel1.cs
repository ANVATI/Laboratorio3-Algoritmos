using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.Events;
using System;

public class GameManagerControlNivel1 : MonoBehaviour
{
    public TextMeshProUGUI Textcontador;
    public TextMeshProUGUI TextCoin;
    public TextMeshProUGUI TextLife;
    public float time = 0;
    public GameObject Options;
    public int coinCount = 0;
    public int lifeCount = 0;
    public Action OnCoinCollected;

    void Start()
    {
        Coin.OnCoinCollected += UpdateCoinCount;
        PlayerMovement.OnHeartCollected += UpdateLifeCount;
        PlayerMovement.OnLose += OnLose;
        PlayerMovement.OnWin += OnWin;

    }
    private void OnDestroy()
    {
        Coin.OnCoinCollected -= UpdateCoinCount;
        PlayerMovement.OnHeartCollected -= UpdateLifeCount;
        PlayerMovement.OnLose -= OnLose;
        PlayerMovement.OnWin -= OnWin;

    }
    void Update()
    {
        UpdateCounter();
    }

    public void UpdateCounter()
    {
        time += Time.deltaTime;
        Textcontador.text = "Contador: " + time.ToString("F0") + " Segundos";
    }

    public void AppearOptionsContainer()
    {
        Options.SetActive(true);
        Time.timeScale = 0;
    }

    public void DisappearOptionsContainer()
    {
        Options.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Nivel 1");
        Time.timeScale = 1;
    }

    public void ReturnMenú()
    {
        SceneManager.LoadScene("Menú");
        Time.timeScale = 1;
    }
    public void UpdateCoinCount()
    {
        coinCount = coinCount + 1;
        TextCoin.text = "X" + coinCount;
    }
    public void UpdateLifeCount()
    {
        lifeCount = lifeCount + 1;
        TextLife.text = "+" + lifeCount;
    }
    public void OnLose()
    {
        SceneManager.LoadScene("Derrota");
    }
    public void OnWin()
    {
        SceneManager.LoadScene("Victoria");
    }
}
