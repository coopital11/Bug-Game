using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carrot : MonoBehaviour
{

    
    private void OnTriggerEnter2D(Collider2D collisioin)
    {
        Destroy(gameObject);
        bugs.score++;
        Debug.Log(bugs.score);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
