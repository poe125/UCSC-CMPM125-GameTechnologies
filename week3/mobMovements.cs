using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class mobMovements : MonoBehaviour
{
    Vector3 pos;
    Vector3 movement = new Vector3(-1, 0, 0);
    Vector3 spawnpoint = new Vector3(5, 0, 3);
    bool collideCh = false;
    public charMovement charMove1;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = spawnpoint;
    }


    private void OnTriggerEnter(Collider other)
    {
        //add ‰Á‘¬“x
        if (other.CompareTag("leftwall"))
        { //move right
            movement = Vector3.right;
        }
        else if (other.CompareTag("rightwall"))
        { //move right
            movement = Vector3.left;
        }
        else //hit the character
        {
            collideCh = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!collideCh)
        {
            transform.position += movement * Time.deltaTime * Random.Range(5f,15f);
        }
        else
        {
            transform.position += movement * Time.deltaTime * Random.Range(5f,15f);
            //explosion
        }
    }
}

