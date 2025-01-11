using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isBomb : MonoBehaviour
{
  public GameObject boomParticleSystemPrefab;
    private GameObject player;
    private AudioSource playerAudioSource;
    private playerMove playerMove;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("man");
        if (player != null)
        {
        playerAudioSource = player.gameObject.GetComponent<AudioSource>();
        playerMove = player.gameObject.GetComponent<playerMove>();
        }
    }

    // Update is called once per frame
  

 private void OnTriggerEnter2D(Collider2D collision)
  {   
      if(collision.gameObject.tag == "man")
      {
        Instantiate(boomParticleSystemPrefab, transform.position, Quaternion.identity);
        playerAudioSource.Play();
        playerMove.hitPlayer();
        Destroy(gameObject);
      }
       if(collision.gameObject.tag == "mainGround")
       {
         Destroy(gameObject);
       }

  }


}
