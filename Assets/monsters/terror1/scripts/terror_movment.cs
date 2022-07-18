using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terror_movment : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 200f; 
    public bool isDetected = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {  
        if(!isDetected && !GetComponent<thowables>().is_thrown)
        {
            rb.velocity = new Vector2(speed * Time.fixedDeltaTime,0);
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));

        }
        else
        {
        }
    }

    void flip()
    {
        speed *= -1;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(!isDetected && other.tag != "player_pickup")
            flip();

    }
}
