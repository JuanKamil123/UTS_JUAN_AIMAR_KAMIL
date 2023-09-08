using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScripPaddle : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 _direction;
    public float speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-5,0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(5,9);
        }
        else { rb.velocity = new Vector2(0,0);
        }
    }

    void FixedUpdate()
    { if(_direction == Vector2.zero) {return; }

    rb.AddForce(_direction * speed);
    }
}
