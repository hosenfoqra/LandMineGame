using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-7.37f,-2.76f,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3 (0.003f,0,0);
    }
}
