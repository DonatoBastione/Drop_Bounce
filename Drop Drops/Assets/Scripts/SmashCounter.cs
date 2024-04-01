using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SmashCounter : MonoBehaviour
{
    public RawImage immagine;
    public Texture texturePronto;
    public Texture textureNonPronto;

    

    // Update is called once per frame
    void Update()
    {
        if(Player.smashReady){
            immagine.texture = texturePronto;
        }else{
            immagine.texture = textureNonPronto;
        }
        
    }
}
