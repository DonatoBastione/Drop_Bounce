using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpeedScript : MonoBehaviour
{
    public TMP_Text speed;
    

    // Update is called once per frame
    void Update()
    {
        speed.text = Player.velocityPercentage.ToString();
        
    }
}
