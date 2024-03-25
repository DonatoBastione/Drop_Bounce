using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Player.velocityPercentage == 0){
            GetComponent<BoxCollider2D>().sharedMaterial = null;
        }
    }
}
