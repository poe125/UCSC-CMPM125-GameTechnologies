using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goal;
    public MainCharacter character;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Score: " + character.score);
        if (character.score < 60)
        {
            goal.SetActive(false);
        } else
        {
            goal.SetActive(true);
        }
    }
}
