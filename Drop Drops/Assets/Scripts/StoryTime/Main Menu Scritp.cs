using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScritp : MonoBehaviour
{
    public GameObject AssiDiLegno;
    public GameObject ButFirst;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PrimaParte(){
        AssiDiLegno.SetActive(false);
        ButFirst.SetActive(true);
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
}
