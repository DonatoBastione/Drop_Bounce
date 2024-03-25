using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject player;


    void FixedUpdate() {
      if(player.transform.position.y < -3){
        transform.position = new Vector3(player.transform.position.x, -3, transform.position.z);
      }else if(player.transform.position.y > 5){
        transform.position = new Vector3(player.transform.position.x, 5, transform.position.z);
      }else{
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
      }
      
    }
}
