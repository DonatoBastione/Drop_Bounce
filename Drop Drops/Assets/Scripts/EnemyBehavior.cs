using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    private float speed;

    public static bool changeVelocity;

    public Animator animator;
    
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed) * Player.velocityPercentage;
    }
    // Update is called once per frame
    void Update()
    {

        
        if(changeVelocity){
            
            speed *= Player.velocityPercentage;
            changeVelocity = false;

        }
        if(Player.velocityPercentage != 0){
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }else if (gameObject.layer != 6){
            transform.Translate(Vector2.right * minSpeed * Time.deltaTime);
        }
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Player"){
            animator.SetBool("Smashed", true);
        }
    }

    
    
}
