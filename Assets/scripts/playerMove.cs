using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class playerMove : MonoBehaviour
{

public Transform groundCheck;
public LayerMask groundLayer;
bool isGrounded;




    public bool Level1 = false; 
    public GameObject instructions;
    private animatorScript animatorScript;
    public bool door = false;
    public int keys = 0;
    public GameObject key1;
     public GameObject x2;
    public TextMeshProUGUI healthText;
  
    private Animator playerAnimator;
    private Rigidbody2D rb2d;
  // Rigidbody2D rb;
    private float input;
    private bool jump = false;
    private bool isOnGround = true;
   
    [SerializeField] float playeSpeed = 7f;
    public int health = 4; 
    //[SerializeField] float jumpForce = 15;

     void Awake() {
      
       animatorScript = GameObject.FindObjectOfType<animatorScript>();
     }
    void Start()
    {
   if (SceneManager.GetActiveScene().name == "level1") 
     {
        Level1 = true; 
     }

        rb2d = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
         healthText.text = "Health = "+ health;
        //healthText = GameObject.FindObjectOfType<TextMeshProUGUI>();
    }

    
    void Update()
    {
        isGrounded = Physics2D.OverlapCapsule(groundCheck.position,new Vector2(0.1f ,0.4f ) , CapsuleDirection2D.Horizontal, 0 , groundLayer);
        /////////////////////jumb/////////////////*
        if (Input.GetButton("Jump") && isGrounded)
        {
            jump = true;
           // ExecuteAfterTime(1.3f);
             
        }
       
       input = Input.GetAxisRaw("Horizontal");

        if(input != 0 )
            {
                playerAnimator.SetBool("isWalk", true);
            }
            else
            {
                playerAnimator.SetBool("isWalk", false);
            }
        if (input<0){
            transform.eulerAngles = new Vector3(0,180,0);
    }
        else if (input > 0){
            transform.eulerAngles = new Vector3(0,0,0);
        }
    }

IEnumerator ExecuteAfterTime(float time)
 {
     yield return new WaitForSeconds(time);
 
     // Code to execute after the delay
 }


    private void FixedUpdate() {

rb2d.velocity = new Vector2(input * playeSpeed,rb2d.velocity.y);   
if (rb2d.velocity.y < 0)
{
    rb2d.gravityScale = 12.5f;
}
else    
    {
     rb2d.gravityScale = 10;
    }


if (jump)
{
    rb2d.AddForce(new Vector2(0, 23 ) , ForceMode2D.Impulse);
    jump = false;
    
    
} 
         

    }

    public void hitPlayer()
    {
        health = health - 1;
        //print(health);
        healthText.text = "Health = "+ health;
        if (health == 0)
        {
            //Destroy(gameObject , 0.35f);
            gameObject.SetActive (false);
            Invoke("reloadScene",1.5f);
        }
    }

    public void reloadScene()
    {
    
        SceneManager.LoadScene(0);
    }




    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "ground")
        {
            isOnGround = true;
        }
         animatorScript.updateKey( keys);
    }
   
      
     private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isOnGround = false;
            ExecuteAfterTime(2.2f);
        }
       
    }


    private void OnTriggerEnter2D(Collider2D other)
  {   
      if(other.gameObject.CompareTag("key"))
      {
          keys ++;
          key1.SetActive(true);
          Destroy(other.gameObject);
          if (keys == 2)
             x2.SetActive(true);

      //////animatorScript.updateKey( keys);
      //animatorScript.level(Level1);
      

      }
       if(other.gameObject.CompareTag("door"))
      {
          if (keys>0 && Level1)
            animatorScript.openDoor(true);
             if (keys>1 && !(Level1))
            animatorScript.openDoor(true);
            //instructions.SetActive(true);
             ///animatorScript.level(Level1);
      }
  }

 private void OnTriggerStay2D(Collider2D other)
 {
     if(other.tag == "door" && keys < 1 && Level1)
     {
        instructions.SetActive(true);
     }
     else if(other.tag == "door" && keys < 2 && !(Level1))
     {
         instructions.SetActive(true);
         
     }
 }
 private void OnTriggerExit2D(Collider2D other)
 {
     if(other.tag == "door")
     {
         instructions.SetActive(false);
         
     }
 }




  

public int getDoor()
    {
        return keys;
   }
   public bool getlevl1()
    {
        return Level1;
   }



}
 