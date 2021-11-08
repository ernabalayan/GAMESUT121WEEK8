using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    public BoxCollider2D boxCollider;
    public SpriteRenderer spriteRenderer;
    public GameObject coin;
    public int maxNumberOfCoins;
    // Start is called before the first frame update

   
 
    void Start()
    {
        spriteRenderer.enabled = true;
        boxCollider.enabled = true;
         
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.enabled = false;
        boxCollider.enabled = false;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
