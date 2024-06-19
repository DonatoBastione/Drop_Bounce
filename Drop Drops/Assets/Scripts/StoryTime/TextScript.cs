using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour
{
    // Start is called before the first frame update
    public bool fadeIn = false;
    public bool fadeOut = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(fadeIn){
            if(gameObject.GetComponent<CanvasGroup>().alpha < 1){
                gameObject.GetComponent<CanvasGroup>().alpha += Time.deltaTime;
                if(gameObject.GetComponent<CanvasGroup>().alpha >= 1){
                    fadeIn = false;
                }
            }
        }
        if(fadeOut){
            if(gameObject.GetComponent<CanvasGroup>().alpha >= 0){
                gameObject.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
                if(gameObject.GetComponent<CanvasGroup>().alpha == 0){
                    fadeOut = false;
                }
            }
        }
    }
}
