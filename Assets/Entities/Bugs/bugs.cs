 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugs : MonoBehaviour
{

    Animator animator;

    public static int health = 3;
    public static int score = 0;
    public static bool hit = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.anyKey)
        {
            animator.SetBool("BugsWalking", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0.01f, 0, 0);
            animator.SetBool("BugsWalking", true);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-0.01f, 0, 0);
            animator.SetBool("BugsWalking", true);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 0.01f, 0);
            animator.SetBool("BugsWalking", true);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -0.01f, 0);
            animator.SetBool("BugsWalking", true);
        }

        if (health < 1)
        {
            Application.LoadLevel("Lose");
        }


        if (score > 5)
        {
            Application.LoadLevel("Win");
        }

    }
}
