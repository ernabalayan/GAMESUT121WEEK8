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

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<MyPathSystem>().CreateNewPath();
        player.transform.position = new Vector3(-1, -8, -3);
        Debug.Log("destroyed player");
    }
    // Update is called once per frame
    void Update()
    {
       

    }
}
