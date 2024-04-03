using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Parallassi : MonoBehaviour
{
    public float startMoveSpeed;
    float moveSpeed;
    float sinlgeTextureWidth;
    public float scale;

    public bool changeVelocity;


    // Start is called before the first frame update
    void Start()
    {
        changeVelocity = false;
        moveSpeed = startMoveSpeed;
        setupTexture();
    }

    //Setuppa la texture
    void setupTexture(){

        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        sinlgeTextureWidth = sprite.texture.width / sprite.pixelsPerUnit;
    }

    //Fa scrollare la texture
    void Scroll(){
        if (changeVelocity){
            moveSpeed = startMoveSpeed * Player.velocityPercentage;
            changeVelocity = false;
        }
        float delta = moveSpeed * Time.deltaTime;
        transform.position -= new Vector3(delta, 0, 0);
    }

    //Controlla se la è andata troppo oltre e va resettata
    void CheckReset(){
        if((Mathf.Abs(transform.position.x) - sinlgeTextureWidth * scale) > 0)
        {
            transform.position = new Vector3(0.0f, transform.position.y, transform.position.z);
        }
    }
    
    void FixedUpdate()
    {
        Scroll();
        CheckReset();
    }
}
