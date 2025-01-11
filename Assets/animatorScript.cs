using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animatorScript : MonoBehaviour
{
    public bool level1 = false;
    int keys = 0;
    public bool door = false ;
     private Animator animatorDoor;
    private playerMove playerMove;

    void Start()
    {
 if (SceneManager.GetActiveScene().name == "level1") 
     {
        level1 = true; 
     }

        animatorDoor = GetComponent<Animator>();


       // animatorDoor.SetBool("open1" , true);
    }





    void Update()
    {
        if (animatorDoor != null)
        {
            if (keys==1 && level1 && door)
            {
                 animatorDoor.SetBool("open", true);
                 Invoke("level2",1.5f);
            }


            if (keys==2 && door)
            {
             animatorDoor.SetBool("open", true);
             Invoke("level3",1.5f);
               //SceneManager.LoadScene(1);
            }
           /* else if (door)
            {
                Debug.Log("you need a keys");
            }
      /**/
        }
    }
    void level2()
    {
        SceneManager.LoadScene(2);
    }
    void level3()
    {
        SceneManager.LoadScene(3);
    }
    // [SerializeField] GameObject player;
    /*void Awake() {
       // playerMove = GameObject.Find("player").GetComponent<playerMove>();
       playerMove = GameObject.FindObjectOfType<playerMove>();
      //  keys = playerMove.getDoor();
      //  if (keys)
          //  animatorDoor.SetBool("open", true);
    }
       // */
/*
 private void OnTriggerEnter2D(Collider2D other)
  {   
       if(other.gameObject.CompareTag("door"))
      {   
          if (playerMove.getDoor())
            {
             animatorDoor.SetBool("open", true);
             Debug.Log("its workkk");
            }
            else
            {
                Debug.Log("you need a keys");
            }
      }
  

  }
*/

  public void openDoor(bool doors)
  {   
      door = doors;



    /*
            if (keys)
            {
             animatorDoor.SetTrigger("open1");
             Debug.Log("its workkk");
            }
            else
            {
                Debug.Log("you need a keys");
            }
      */
  }
  
  public void level(bool levels)
  {   
      level1 = levels;


}

public void updateKey(int key){
    keys = key;
    
}


  
}

