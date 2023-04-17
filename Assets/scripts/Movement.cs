
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public quadratic curve;
    public float pTime;
    public float time;
    public Vector3 startPosition;
    

    

    private void Start()
    {
        pTime = 0f;
        startPosition = transform.position;
       
    }

    private void Update()
    {
        pTime += Time.deltaTime / time;
        transform.position = curve.evaluate(pTime);
        

        if (pTime >= 1f)
        {
            
            
            pTime = 0f;
            //curve.RandomizeB();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            curve.RandomizeB();
           
        }
    }
}
