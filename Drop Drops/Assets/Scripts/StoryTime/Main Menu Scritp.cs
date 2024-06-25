using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScritp : MonoBehaviour
{
    public GameObject AssiDiLegno;
    public GameObject ButFirst;
    public GameObject SelectGame;
    // Start is called before the first frame update
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PrimaParte(){
        AssiDiLegno.SetActive(false);
        ButFirst.SetActive(true);
    }
    public void SecondaParte(){
        ButFirst.SetActive(false);
        SelectGame.SetActive(true);
    }
    public void Play(){
        SceneManager.LoadScene("SampleScene");
    }
    public void Experience(){
        SceneManager.LoadScene("Experience");
    }
    public void Brainrot(){
        SceneManager.LoadScene("Brainrot");
    }
    public void Suika(){
        SceneManager.LoadScene("Suika");
    }
}
