using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mucisVolume : MonoBehaviour
{
  
    public AudioSource AudioSource;
     MuiscPlayerScript MuiscPlayerScript;
     GameObject player;

    private float musicVolume = 1f;
    // Start is called before the first frame update
    void Start()
    {
       // MuiscPlayerScript.updateVolume();
        AudioSource.Play();
         //MuiscPlayerScript = player.GetComponent<MuiscPlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
      //  musicVolume = MuiscPlayerScript.updateVolume();
        AudioSource.volume = musicVolume;   
       
    }

    
      
/*
    public void updateVolume (float volume)
    {

        musicVolume = volume;
    }

    */
}
