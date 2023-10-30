using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class CharacterMovement : MonoBehaviour
{
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    //game over
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal")) //game end
        {
            SceneManager.LoadScene(2);
        }

        if (other.CompareTag("Coin"))
        {
            score++;
            Destroy(other.gameObject);
           // Debug.Log(score);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //var ray = new Ray(transform.position, transform.forward);

        if (Input.GetKey("w"))//walk forward
        {
            transform.position += transform.forward * Time.deltaTime * 5;
        }
        if (Input.GetKey("a"))//walk left
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 70);
        }
        if (Input.GetKey("s")) //walk backwards
        {
            transform.position += (-transform.forward) * Time.deltaTime * 5;
        }
        if (Input.GetKey("d"))//walk right
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 70);
        }
    }
}
