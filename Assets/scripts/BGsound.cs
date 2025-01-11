using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGsound : MonoBehaviour
{

    GameObject bgMuisc;
    AudioSource BGAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        BGAudioSource = bgMuisc.gameObject.GetComponent<AudioSource>();
         BGAudioSource.volume =0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
/*
 void OnGUI()
    {
       
        BGAudioSource.volume =0.5f;
    }
/**/
}
