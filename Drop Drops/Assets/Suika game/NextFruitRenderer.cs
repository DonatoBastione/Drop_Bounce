using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextFruitRenderer : MonoBehaviour
{
    public GameObject controller;
    public Sprite blueberry;
    public Sprite redberry;
    public Sprite lemon;
    public Sprite banana;
    public Sprite orange;
    public Sprite apple;
    public Sprite peach;
    public Sprite coconut;
    public Sprite melon;

    // Update is called once per frame
    void Update()
    {
        switch (controller.GetComponent<Controller>().nextFruit){
            case 0:
                gameObject.GetComponent<RawImage>().texture = blueberry.texture;
                break;
            case 1:
                gameObject.GetComponent<RawImage>().texture = redberry.texture;
                break;
            case 2:
                gameObject.GetComponent<RawImage>().texture = lemon.texture;
                break;
            case 3:
                gameObject.GetComponent<RawImage>().texture = banana.texture;
                break;
            case 4:
                gameObject.GetComponent<RawImage>().texture = orange.texture;
                break;
            case 5:
                gameObject.GetComponent<RawImage>().texture = apple.texture;
                break;
            case 6:
                gameObject.GetComponent<RawImage>().texture = peach.texture;
                break;
            case 7:
                gameObject.GetComponent<RawImage>().texture = coconut.texture;
                break;
            case 8:
                gameObject.GetComponent<RawImage>().texture = melon.texture;
                break;
        }
        
    }
}
