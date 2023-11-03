using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    int distance = 2;
    bool dirty = true;
    public GameObject prefab;
    public MainCharacter character;
    int newY = 0;

        // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     if(character.score == 20 && dirty)
        {
            newY = -11;
            for (int i = 0; i < 10; i++)
            {
                Vector3 coin_position = new Vector3(-9.54f, 1, newY);
                Instantiate(prefab, coin_position, Quaternion.identity);
                newY += distance;
            }
            dirty = false;
        } 
         if(character.score == 21)
        {
            dirty = true;
        }
        if (character.score == 30 && dirty)
        {
            newY = 9;
            for (int i = 0; i < 10; i++)
            {
                Vector3 coin_position = new Vector3(4, 1, newY);
                Instantiate(prefab, coin_position, Quaternion.identity);
                newY -= distance;
            }
            dirty = false;
        }
    }
}
