using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elmer : MonoBehaviour
{


    Animator animator;

    public bool MovingRight = true;

    public bool ElmerFiring = true;

    public GameObject Bullet;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(Bullet, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Debug.Log("Score");
    }
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (MovingRight)
        {
            transform.position += new Vector3(0.01f, 0, 0);
            animator.SetBool("ElmerWalking", true);
            animator.SetBool("ElmerWalkingLeft", false);
        }

        if (!MovingRight)
        {
            transform.position += new Vector3(-0.01f, 0, 0);
            animator.SetBool("ElmerWalking", false);
            animator.SetBool("ElmerWalkingLeft", true);
        }

        if (transform.position.x >8)
        {
            MovingRight = false;
        }

        if (transform.position.x < -8)
        {
            MovingRight = true;
        }

        if (Random.value <0.001)
        {
            MovingRight = !MovingRight;
        }

        

        if (Random.value < 0.001f)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }





    }
}
