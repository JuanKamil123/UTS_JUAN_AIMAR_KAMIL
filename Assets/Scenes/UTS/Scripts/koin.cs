using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class koin : MonoBehaviour
{
    public int nilaiscore;
    Rigidbody2D rb;

    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Score.text = nilaiscore +" ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            nilaiscore +=1;
            Score.text = nilaiscore +" ";
        }
    } 
}
