using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<MyPathSystem>().CreateNewPath();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
