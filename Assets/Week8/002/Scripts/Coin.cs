using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Text coinText;
    public BoxCollider2D boxCollider;
    public SpriteRenderer spriteRenderer;
    public int score = 0;
    public GameObject coin;
    public int maxNumberOfCoins;
    // Start is called before the first frame update

   
 
    void Start()
    {
        coinText = GameObject.Find("CoinText").GetComponent<Text>();
        coinText.text = "Score: " + score;
        spriteRenderer.enabled = true;
        boxCollider.enabled = true;
         
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.enabled = false;
        boxCollider.enabled = false;
        score = + 1;
    }
    // Update is called once per frame
    void Update()
    {

        Debug.Log(score);
    }
}
