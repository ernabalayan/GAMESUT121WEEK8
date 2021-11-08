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
        coinText.text = "Score: " + score;
        spriteRenderer.enabled = true;
        boxCollider.enabled = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.enabled = false;
        boxCollider.enabled = false;
        score++;
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < maxNumberOfCoins; i++)
        {
            float x = Random.Range(-8.0f, 8.0f);
            float y = Random.Range(-5.0f, 5.0f);
            GameObject b = Instantiate(coin, new Vector3(x, y), Quaternion.identity);
        }

    }
}
