using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(0);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
