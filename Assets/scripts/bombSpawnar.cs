using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bombSpawnar : MonoBehaviour
{
[SerializeField] GameObject bomb;
float Timer;
[SerializeField]float gravityScale ;
[SerializeField]float TimeBetween = 25f;
Rigidbody2D rb2d;
    void Start()
    {
        Timer = TimeBetween;
        rb2d = bomb.GetComponent<Rigidbody2D>();
    }

  
    void Update()
    {
        Timer = Timer - Time.deltaTime;
        if (Timer <=0 )
        {
            float x = Random.Range(-8f , 8f);
        if (SceneManager.GetActiveScene().name == "level2") 
         {     
            TimeBetween = Random.Range(0 ,1f);
            gravityScale = Random.Range(7 ,11f);
         }
         if (SceneManager.GetActiveScene().name == "level1") 
         {     
            TimeBetween = Random.Range(1 ,3f);
            gravityScale = Random.Range(3 ,6f);
         }
            Instantiate(bomb, new Vector3(x,5,0) , Quaternion.identity ) ;
            Timer = TimeBetween;
        }
    }

    private void FixedUpdate() {
        rb2d.gravityScale = gravityScale;
    }
}
