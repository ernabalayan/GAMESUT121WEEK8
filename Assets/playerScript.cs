using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public static playerScript instance;
    public Rigidbody2D rb;
    public float moveSpeed;
    public float xInput;
    public float yInput;
    public bool moveLeft;
    public bool moveUp;
    public bool moveRight;
    public bool moveDown;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    
    }

    // Update is called once per frame
    void Update()
    {
        MoveControl();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(-2, -8, -3);
        }
    }
    void MoveControl()
    {
        if (Input.GetKey(KeyCode.D))
        {
            xInput = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            xInput = -1;
        
        }
        else
        {
            xInput = 0;
        }
        if (Input.GetKey(KeyCode.S))
        {
            yInput = -1;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            yInput = 1;
        }
        else
        {
            yInput = 0;
        }

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(xInput, yInput) * moveSpeed * Time.deltaTime;
    }
}
