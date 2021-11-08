using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxNumberOfEnemies;
    public GameObject enemy;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < maxNumberOfEnemies; i++)
        {
            float x = Random.Range(-2.0f, 10.0f);
            float y = Random.Range(-3.0f, 7.0f);
            GameObject b = Instantiate(enemy, new Vector3(x, y), Quaternion.identity);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(player);
        Debug.Log("destroyed player");
    }
    // Update is called once per frame
    void Update()
    {
       

    }
}
