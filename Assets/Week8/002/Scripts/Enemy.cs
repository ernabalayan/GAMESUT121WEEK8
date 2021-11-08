using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxNumberOfEnemies;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(GameObject.Find("Player"));
    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < maxNumberOfEnemies; i++)
        {
            float x = Random.Range(-8.0f, 8.0f);
            float y = Random.Range(-5.0f, 5.0f);
            GameObject b = Instantiate(enemy, new Vector3(x, y), Quaternion.identity);
        }
    }
}
