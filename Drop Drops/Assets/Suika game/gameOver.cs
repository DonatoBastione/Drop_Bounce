using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    public GameObject UI;
    public GameObject controller;
    // Start is called before the first frame update
    
    private void OnCollisionEnter2D(Collision2D other) {
        controller.GetComponent<Controller>().gameOver = true;
        UI.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart (){
        Controller.gamescore = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit(){
        Controller.gamescore = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu Screen");
    }
}
