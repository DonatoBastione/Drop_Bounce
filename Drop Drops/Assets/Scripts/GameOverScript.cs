using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public GameObject gameOverPanel;
    void Update()
    {
        if(Player.velocityPercentage == 0){
            gameOverPanel.SetActive(true);
        }
    }
    public void Restart(){
        Player.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Menu(){
        Player.score = 0;
        SceneManager.LoadScene("Main Menu Screen");
    }
}
