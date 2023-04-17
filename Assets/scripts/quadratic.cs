
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quadratic : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public Transform Control;
    //Vector3 st;
    //Vector3 ed;
    //public float co;

   

    
    public Vector3 evaluate(float t)
    {

        Vector3 ac, cb;
        ac = Vector3.Lerp(A.position, Control.position, t);
        cb = Vector3.Lerp(Control.position, B.position, t);

        return Vector3.Lerp(ac, cb, t);
       
    }

    public void RandomizeBPosition(Vector3 newPosition)
    {
        B.position = newPosition;
       
       
    }

   

    private void OnDrawGizmos()
    {
        if (A == null || B == null || Control == null)
        {
            return;
        }
        for (int i = 0; i < 30; i++)
        {
            Gizmos.DrawWireSphere(evaluate(i / 20f), 0.1f);
        }
    }

    

    public void RandomizeB()
    {
        Vector3 newBPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        //Vector3 oldBPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        RandomizeBPosition(newBPosition);
    }
   
}


