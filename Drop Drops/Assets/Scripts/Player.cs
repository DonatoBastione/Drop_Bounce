using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    public static float velocityPercentage; // percentuale velocità (va da 0.0 a 1.0)

    private Rigidbody2D rb; //getting the rigidbody
    public float smashForce; //forza che viene applicata quando viene utilizzato lo schianto
    public static bool smashReady; //bool per verificare se lo schianto è pronto
    private int smashReadyCounter;
    private bool smashing; //bool per verificare se il personaggio stà schiantando

    public GameObject smashHitBox;

    // Start is called before the first frame update
    void Start()
    {   
        velocityPercentage = 1;
        rb = GetComponent<Rigidbody2D>();
        smashReady = false;
        smashReadyCounter = 0;
        smashing = false;
        rb.AddForce(Vector2.up * smashForce, ForceMode2D.Impulse); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
        Touch();
    }

    void Touch(){
        if (Input.touchCount > 0 && smashReady && velocityPercentage != 0){
            if(rb.velocity.y>0){
                rb.velocity = -rb.velocity;  //se il player sta salendo, mandalo con la stessa velocità giù
            }
            rb.AddForce(Vector2.down * smashForce, ForceMode2D.Impulse); 
            smashReady = false;
            smashReadyCounter = 0;
            smashing = true;
        }  
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        //Collisione col pavimento
        if (collision.gameObject.name == "Floor"){
            if (smashing){
                smashing = false;
                ActivateSmashHitBox();
                SmashBounce();
            }else{
                DecelleraPoco();
            }
        }
        //Collisione con un nemico buono
        if (collision.gameObject.CompareTag("Enemy") && velocityPercentage != 0){
            if (smashing){
                smashing = false;
                ActivateSmashHitBox();
                SmashBounceEnemy();
            }else{
                SmashLogic();
                BounceEnemy();
            }
            collision.gameObject.layer = 6;
        }else if(collision.gameObject.CompareTag("Enemy Bad") && velocityPercentage != 0){
            if (smashing){
                smashing = false;
                ActivateSmashHitBox();
                SmashBounceEnemy();
            }else{
                SmashLogic();
                BounceEnemyBad();
            }
            collision.gameObject.layer = 6;
        }else if(collision.gameObject.CompareTag("Enemy Good") && velocityPercentage != 0){
            if (smashing){
                smashing = false;
                ActivateSmashHitBox();
                SmashBounceEnemy();
            }else{
                SmashLogic();
                BounceEnemyGood();
            }
            collision.gameObject.layer = 6;
        }
        //Collisione con un nemico cattivo
    }

    private void Accellera(){
        velocityPercentage = velocityPercentage + 0.3f;
        if (velocityPercentage > 1){
            velocityPercentage = 1;
        }
        Parallassi.changeVelocity = true;
        EnemyBehaviour.changeVelocity = true;
    }

    private void Decellera(){
        velocityPercentage -= 0.3f;
        if (velocityPercentage < 0){
            velocityPercentage = 0;
            gameObject.layer = 9;
        }
        Parallassi.changeVelocity = true;
        EnemyBehaviour.changeVelocity = true;
    }
    private void DecelleraPoco(){
        velocityPercentage -= 0.15f;
        if (velocityPercentage < 0){
            velocityPercentage = 0;
            gameObject.layer = 9;
        }
        Parallassi.changeVelocity = true;
        EnemyBehaviour.changeVelocity = true;
    }

    private void ActivateSmashHitBox(){
        smashHitBox.layer = 11;
        StartCoroutine(DeactivateSmashHitBox());
    }
    private IEnumerator DeactivateSmashHitBox(){
        yield return new WaitForSeconds(0.2f);
        smashHitBox.layer = 10;
    }
    private void BounceEnemy(){   
        rb.velocity = rb.velocity.y > 0? rb.velocity*8/9 : -rb.velocity;
    }
    private void BounceEnemyBad(){
        rb.velocity = rb.velocity.y > 0? rb.velocity * 2/3 : -rb.velocity*3/5;
        Decellera();
    }
    private void BounceEnemyGood(){
        rb.velocity = rb.velocity.y > 0? rb.velocity*10/9  : -rb.velocity*10/9;
        Accellera();
    }
    private void SmashBounce(){
        rb.velocity = rb.velocity.y > 0? rb.velocity * 6/5 : -rb.velocity*3/4;
        Accellera();
    }
    private void SmashBounceEnemy(){
        rb.velocity = rb.velocity.y > 0? rb.velocity*25/24  : -rb.velocity;
        Accellera();
    }
    private void SmashLogic(){
        if (smashReadyCounter<2){
            smashReadyCounter++;
        }else{
            smashReady = true;
        }
    }
}
