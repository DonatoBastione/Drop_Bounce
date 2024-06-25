using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject blueberry;
    public GameObject redberry;
    public GameObject lemon;
    public GameObject banana;
    public GameObject orange;
    public GameObject apple;
    public GameObject peach;
    public GameObject coconut;
    public GameObject melon;
    public GameObject ananas;
    public int maxFruit;
    private GameObject[] fruitlist = new GameObject[10];
    public static int gamescore = 0;
    public int nextFruit;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        Screen.orientation = ScreenOrientation.Portrait;
        fruitlist[0] = blueberry;
        fruitlist[1] = redberry;
        fruitlist[2] = lemon;
        fruitlist[3] = banana;
        fruitlist[4] = orange;
        fruitlist[5] = apple;
        fruitlist[6] = peach;
        fruitlist[7] = coconut;
        fruitlist[8] = melon;
        fruitlist[9] = ananas;
        nextFruit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && !gameOver){
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Ended){
                Vector2 translatedTouchPos = Camera.main.ScreenToWorldPoint(touch.position);
                if(translatedTouchPos.y > 3.1){
                    Instantiate(fruitlist[nextFruit], translatedTouchPos, Quaternion.identity);
                    nextFruit = randomFruit();
                }
            }
        }
    }
    int randomFruit(){
        return Random.Range(0,maxFruit);
    }
    
}
