using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float xSpeed = 3f;
    [SerializeField] float xMinLimit = -6f, xMaxLimit = 6f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the player presses left
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (rb.position.x > xMinLimit)
            {
                rb.position -= new Vector2(xSpeed,0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (rb.position.x < xMaxLimit)
            {
                rb.position += new Vector2(xSpeed,0);
                //move him right
            }
        }
    }

   
}
