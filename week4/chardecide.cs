using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class chardecide : MonoBehaviour
{
    public int characterNumber = 0;
    // bool ObjectHit = false;

    // Update is called once per frame
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Cast a ray from the camera through the mouse pointer

            RaycastHit hit; // This will store information about the hit object

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "yellowBall")
                {
                    characterNumber = 1;
//                    ObjectHit = true;
                  //  Debug.Log("Character Number: " + characterNumber);
                }
                else if (hit.collider.gameObject.tag == "redBall")
                {
                    characterNumber = 2;
  //                  ObjectHit = true;
                    //Debug.Log("Character Number: " + characterNumber);
                }
                else if (hit.collider.gameObject.tag == "blueBall")
                {
                    characterNumber = 3;
    //                ObjectHit = true;
                   // Debug.Log("Character Number: " + characterNumber);
                }
            }
        }
    }
}
//what happens when the object collides with the car()
//make the y axis the same as the car
//make the selection sphere and the wall transparent
//duplicate cars and make the speed random