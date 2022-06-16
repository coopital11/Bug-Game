using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(bugs.hit)
        {
            bugs.score++;
        }
        
        if(!bugs.hit)
        {
            bugs.health--;
        }
        
        Destroy(gameObject);
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0.01f, 0);

    }
}
