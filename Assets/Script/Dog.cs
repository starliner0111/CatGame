using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float x = mousePos.x;
        if (x > 2)
        {
            x = 2;
        }
        if (x < -2)
        {
            x = -2;
        }
        transform.position = new Vector3(x, transform.position.y); 
     }
 }

