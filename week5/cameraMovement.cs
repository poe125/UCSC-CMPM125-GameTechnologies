using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public chardecide charDecide;
    public charMovement charmovement;
    public charMovement2 charmovement2;
    public charMovement3 charmovement3;
    //GameManager gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 1, -10);
    }
    

      // Update is called once per frame
    void Update()
    {

      if (charDecide.characterNumber == 0)
        {
            //null
        } else if(charDecide.characterNumber == 1)
        {
             if (Input.GetKey("w"))//walk forward
                {
                    transform.position += Vector3.forward * Time.deltaTime * 5;
                }
                 if (Input.GetKey("s")) //walk backwards
                {
                    transform.position += Vector3.back * Time.deltaTime * 5;
                }
            if (charmovement.gameover1)
            {
                transform.position = new Vector3(0, 1, -10);
                charmovement.gameover1 = false;
            }
            if (charmovement.savePoint1)
            {
                transform.position = new Vector3(0, 2, 36);
            }
        } else if (charDecide.characterNumber == 2)
        {
            if (Input.GetKey("w"))//walk forward
            {
                transform.position += Vector3.forward * Time.deltaTime * 7;
            }
            if (Input.GetKey("s")) //walk backwards
            {
                transform.position += Vector3.back * Time.deltaTime * 7;
            }
            if (charmovement2.gameover2)
            {
                transform.position = new Vector3(0, 1, -10);
                charmovement2.gameover2 = false;
            }
            if (charmovement2.savePoint2)
            {
                transform.position = new Vector3(0, 2, 36);
            }
        } else if (charDecide.characterNumber == 3)
        {
            if (Input.GetKey("w"))//walk forward
            {
                transform.position += Vector3.forward * Time.deltaTime * 9;
            }
            if (Input.GetKey("s")) //walk backwards
            {
                transform.position += Vector3.back * Time.deltaTime * 9;
            }
            if (charmovement3.gameover3)
            {
                transform.position = new Vector3(0, 1, -10);
                charmovement3.gameover3 = false;
            }
            if (charmovement3.savePoint3)
            {
                transform.position = new Vector3(0, 2, 36);
            }
        }   
     }
}
