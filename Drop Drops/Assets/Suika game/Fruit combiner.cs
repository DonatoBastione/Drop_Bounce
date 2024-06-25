using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruitcombiner : MonoBehaviour
{
    public bool HasCollided = false;
    public GameObject NextFruit;
    public GameObject controller;
    
    void Start(){
        controller = GameObject.Find("Controller");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name != gameObject.name){
            return;
        }
        if (HasCollided){
            return;
        }
        
        var otherScript = collision.gameObject.GetComponent<Fruitcombiner>();
        
        otherScript.HasCollided = true;
        HasCollided = true;
        if (collision.gameObject.name == "Red Berry(Clone)"){
            if(controller.GetComponent<Controller>().maxFruit == 1){
                controller.GetComponent<Controller>().maxFruit = 2;
            }
        }
        if (collision.gameObject.name == "Lemon(Clone)"){
            if(controller.GetComponent<Controller>().maxFruit == 2){
                controller.GetComponent<Controller>().maxFruit = 3;
            }
        }
        if (collision.gameObject.name == "Banana(Clone)"){
            if(controller.GetComponent<Controller>().maxFruit == 3){
                controller.GetComponent<Controller>().maxFruit = 4;
            }
        }
        if (collision.gameObject.name == "Orange(Clone)"){
            if(controller.GetComponent<Controller>().maxFruit == 4){
                controller.GetComponent<Controller>().maxFruit = 5;
            }
        }
        if (collision.gameObject.name == "Apple(Clone)"){
            if(controller.GetComponent<Controller>().maxFruit == 5){
                controller.GetComponent<Controller>().maxFruit = 6;
            }
        }
        if (collision.gameObject.name == "Peach(Clone)"){
            if(controller.GetComponent<Controller>().maxFruit == 6){
                controller.GetComponent<Controller>().maxFruit = 7;
            }
        }
        if (collision.gameObject.name == "Coconut(Clone)"){
            if(controller.GetComponent<Controller>().maxFruit == 7){
                controller.GetComponent<Controller>().maxFruit = 8;
            }
        }
        if (collision.gameObject.name == "Melon(Clone)"){
            if(controller.GetComponent<Controller>().maxFruit == 8){
                controller.GetComponent<Controller>().maxFruit = 9;
            }
        }
        if (collision.gameObject.name == "Ananas(Clone)"){
            if(controller.GetComponent<Controller>().maxFruit == 9){
                controller.GetComponent<Controller>().maxFruit = 10;
            }
        }
        Controller.gamescore++;
        GetComponent<AudioSource>().Play();
        Instantiate(NextFruit, gameObject.transform.position, Quaternion.identity);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
