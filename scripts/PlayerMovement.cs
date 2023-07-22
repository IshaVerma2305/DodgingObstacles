using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{

public float forwardspeed;
public float sidewayspeed;    
public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Hello");
      // rb.useGravity= false;
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardspeed * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayspeed*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayspeed*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
