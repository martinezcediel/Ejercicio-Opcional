using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneLimits : MonoBehaviour
{
    private float limXPos = 10f;
    private float limXNeg = -10f;
    private float limZPos = 5f;
    private float limZNeg = -5f;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x: 0f,y:  0.5f,z: 0f);
    }

    // Update is called once per frame
    void Update()
    {   /*
        transform.Translate(KeyCode.UpArrow, Vector3.forward);
        transform.Translate(KeyCode.RightArrow, Vector3.right);
        transform.Translate(KeyCode.LeftArrow, Vector3.left);
        transform.Translate(KeyCode.DownArrow, Vector3.backwards);
        */


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left);
        }

        /* if (transform.position.x >= limXPos)
         {
             transform.position = new Vector3(limXPos, transform.position.y, transform.position.z);
         }
         if (transform.position.x <= limXNeg)
         {
             transform.position = new Vector3(limXNeg, transform.position.y, transform.position.z);
         }
         if (transform.position.x >= limZPos)
         {
             transform.position = new Vector3(transform.position.x, limZPos, transform.position.z);
         }
         if (transform.position.x <= limZNeg)
         {
             transform.position = new Vector3(transform.position.x, limZNeg, transform.position.z);
         }
        */
        if (transform.position.x > 50)
        {
            transform.position = new Vector3(50, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -50)
        {
            transform.position = new Vector3(-50, transform.position.y, transform.position.z);
        }

        if (transform.position.z > 20)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 20);
        }
        if (transform.position.z < -20)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -20);
        }

    }
}
