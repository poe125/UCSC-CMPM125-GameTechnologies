using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItem : MonoBehaviour
{
    public MainCharacter character;
    int x;
    // Start is called before the first frame update
    void Start()
    { 
            x = Random.Range(-8, 18);
            GameObject.FindWithTag("speedItem").transform.position = new Vector3(x, 1.4f, -7);
            GameObject.FindWithTag("lifeItem").transform.position = new Vector3(8, 1.4f, 8);
            GameObject.FindWithTag("stunItem").transform.position = new Vector3(-100, 100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        if(character.score == 40)
        {
            GameObject.FindWithTag("stunItem").transform.position = new Vector3(-9.4f, 1.4f, -11);
        }
    }
}
