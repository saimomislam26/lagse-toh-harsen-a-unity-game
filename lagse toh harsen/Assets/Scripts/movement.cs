using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float frwrd = 500f;
    public float side = 100f;

    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, frwrd * UnityEngine.Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(side * UnityEngine.Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-side * UnityEngine.Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(rb.position.y <0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
