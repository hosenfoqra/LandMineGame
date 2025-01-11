using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class faded : MonoBehaviour
{
    SpriteRenderer rend;
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    /*    Color c = rend.material.color;
        c.a = 0f;
        rend.material.color = c;*/
           Invoke("StartFading", 3.0f);

            Invoke("reloadScene",5.5f);
        }
    

    public void reloadScene()
    {
    
        SceneManager.LoadScene(0);
    }
    


IEnumerator FadeIn()
{
    for(float f = 1; f>=0.01f ; f -= 0.05f)
    {
        Color c = rend.material.color;
        c.a = f;
        rend.material.color = c;
        yield return new WaitForSeconds (0.05f);
    }
}

public void StartFading()
{
    StartCoroutine("FadeIn");
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
