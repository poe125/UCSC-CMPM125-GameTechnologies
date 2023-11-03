using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCharacter : MonoBehaviour
{
    public int speed = 5;
    public int life;
    public int score = 0;
    Vector3 startPoint = new Vector3(-10, 1.4f, -13);

    private bool dirty = false;
    private int maxLife = 3;
    private float remainTime = 10f;

    // Start is called before the first frame update
    void Start()
    {
        life = maxLife;
        transform.position = startPoint;
        speed = 5;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("item")){
            speed = 8;
            dirty = true;
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Enemy"))
        {
            life--;
            transform.position = startPoint;
        }
        if (other.CompareTag("Coin"))
        {
            score++;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Goal"))
        {
            //Game Finished
            SceneManager.LoadScene(2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 0)
        {
            SceneManager.LoadScene(2);
        }

        if (dirty)
        {
            if (remainTime > 0)
            {
                remainTime -= Time.deltaTime;
            }
            if (remainTime <= 0)
            {
                speed = 5;
                dirty = false;
                remainTime = 10;
            }
        }

        //character movement
        if (Input.GetKey("w"))//walk forward
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey("a"))//walk left
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 80);
        }
        if (Input.GetKey("s")) //walk backwards
        {
            transform.position += (-transform.forward) * Time.deltaTime * speed;
        }
        if (Input.GetKey("d"))//walk right
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 80);
        }
    }
}
