using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSize : MonoBehaviour
{
    // Start is called before the first frame update
    int x;
    int y;
    int z;

    void Start()
    {
        x = Random.Range(1, 4);
        y = Random.Range(1, 4);
        z = Random.Range(1, 4);
        transform.localScale = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
