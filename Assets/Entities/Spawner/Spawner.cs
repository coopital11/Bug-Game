using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject objectToSpawn;

    public float timeToSpawn;
    
    private float currentTimeToSpawn;

    public bool MovingLeft = true;
    
    public bool MovingUp = true;

    public void SpawnObject()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(currentTimeToSpawn > 0)
        {
            currentTimeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            currentTimeToSpawn = timeToSpawn;
        }

        if (MovingLeft)
        {
            transform.position += new Vector3(-0.01f, 0, 0);
           
        }

        if (!MovingLeft)
        {
            transform.position += new Vector3(0.01f, 0, 0);
            
        }

        if (transform.position.x > 8)
        {
            MovingLeft = true;
        }

        if (transform.position.x < -8)
        {
            MovingLeft = false;
        }

        if (Random.value < 0.001)
        {
            MovingLeft = !MovingLeft;
        }

        if (MovingUp)
        {
            transform.position += new Vector3(0, 0.01f, 0);
            
        }

        if (!MovingUp)
        {
            transform.position += new Vector3(0, -0.01f, 0);
           
        }

        if (transform.position.y > 5)
        {
            MovingUp = false;
        }

        if (transform.position.y < -3)
        {
            MovingUp = true;
        }

        if (Random.value < 0.001)
        {
            MovingUp = !MovingUp;
        }

    }

}
