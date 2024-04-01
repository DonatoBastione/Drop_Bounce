using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedScript : MonoBehaviour
{
    public RawImage immagine;
    public Texture red;
    public Texture orange;
    public Texture yellow;
    public Texture green;
    public Texture teal;
    public Texture blue;
    public Texture purple;

    // Update is called once per frame
    void Update()
    {
        if (Player.velocityPercentage == 1){
            immagine.texture = purple;
        }else if (Player.velocityPercentage == 0){
            immagine.texture = red;
        }else if(Player.velocityPercentage < 1 && Player.velocityPercentage >= 0.85 ){
            immagine.texture = blue;
        }else if(Player.velocityPercentage < 0.85 && Player.velocityPercentage >= 0.70 ){
            immagine.texture = teal;
        }else if(Player.velocityPercentage < 0.70 && Player.velocityPercentage >= 0.55 ){
            immagine.texture = green;
        }else if(Player.velocityPercentage < 0.55 && Player.velocityPercentage >= 0.40 ){
            immagine.texture = yellow;
        }else if(Player.velocityPercentage < 40 && Player.velocityPercentage >= 0.25 ){
            immagine.texture = orange;
        }
    }
}
