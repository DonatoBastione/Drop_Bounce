using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpeedCounter : MonoBehaviour
{
    public TMP_Text ready;
    

    // Update is called once per frame
    void Update()
    {
        if(Player.smashReady){
            ready.text = "Ready";
        }else{
            ready.text = "Not Ready";
        }
        
    }
}
