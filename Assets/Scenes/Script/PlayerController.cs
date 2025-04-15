using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    // Start is called before the first frame update
    public float xForce=5.0f;
    public float zForce=5.0f;
    public float yForce=100.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          float x = 0.0f, y = 0.0f, z = 0.0f;
        if (Input.GetKey(KeyCode.A))
        {
           x = x - xForce; 
        }
        if (Input.GetKey(KeyCode.S))
        {
           x = x + xForce; 
        }
        if (Input.GetKey(KeyCode.D))
        {
           z = z + zForce; 
        }
        if (Input.GetKey(KeyCode.F))
        {
           z = z - zForce; 
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
           y = yForce;
        }
        
        
        GetComponent<Rigidbody>().AddForce(x,y,z);
    
        
    }
}