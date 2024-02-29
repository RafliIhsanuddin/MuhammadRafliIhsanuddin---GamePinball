using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    // Start is called before the first frame update



    public Button mainMenuButton;


    public void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
    }



    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
