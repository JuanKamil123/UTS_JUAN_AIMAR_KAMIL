using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaControl : MonoBehaviour
{
    private Rigidbody2D rb { get; set; }
    public float speed = 500f;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Start()
    {
        Invoke(nameof(SetRandomTrajectory), 0.5f);
    }

    private void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-0.5f, 0.5f);
        force.y = -1;

        rb.AddForce(force.normalized * speed);
    }
    
}
