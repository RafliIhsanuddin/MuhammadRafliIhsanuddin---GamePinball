using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    // Start is called before the first frame update



    public Button mainMenuButton;
    public Button retryButton;


    public void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
        retryButton.onClick.AddListener(RetryGame);
    }



    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }



    public void RetryGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }



}
