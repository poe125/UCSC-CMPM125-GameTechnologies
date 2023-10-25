using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public int score = 0;
    private void OnEnable()
    {
    //hide the bullet after 2 sec.
        Invoke("hideBullet",2.0f);
    }

    void hideBullet()
    {
//        gameObject.SetActive(false);
          Destroy(gameObject);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "target") { 
        Destroy(other.gameObject);
            gameObject.SetActive(false);
            score++;
        }
    }
}
