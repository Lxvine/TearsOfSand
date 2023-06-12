using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverMenu;
    private PlayerController playerController;

    public void Start()
    {
       playerController = GameObject
            .FindGameObjectWithTag("Player")
            .GetComponent<PlayerController>();
        playerController.PlayerDeath += ActivateMenu;
    }

    private void ActivateMenu(object sender, EventArgs e)
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
