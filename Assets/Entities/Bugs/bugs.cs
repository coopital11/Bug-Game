 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugs : MonoBehaviour
{

    Animator animator;
    
    
    
    
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
            animator.SetBool("BugsWalking", true);
        }
    }
}
