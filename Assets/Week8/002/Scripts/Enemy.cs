using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

        SceneManager.LoadScene(0);
        Debug.Log("destroyed player");
    }
    // Update is called once per frame
    void Update()
    {
       

    }
}
