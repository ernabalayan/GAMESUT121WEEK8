using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public Text coinText;
    public GameObject coin;
    public int score;
    
    // Start is called before the first frame update
    void Start()
    {
    
        instance = this;
    
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Score: " + score;
        MoveControl();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(-12, -10, 0);
        }

        Debug.Log(score);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            score++;
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
