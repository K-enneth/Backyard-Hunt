using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 100.0f;
   

    void Update()
    {
        float transalatez = Input.GetAxis("Vertical") * speed;
        float transalatex = Input.GetAxis("Horizontal") * speed;
        transalatex *= Time.deltaTime;
        transalatez *= Time.deltaTime;
        
        gameObject.transform.Translate(transalatex, 0, transalatez);


    }
}
