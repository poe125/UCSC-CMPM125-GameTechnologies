using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class MainCharacter : MonoBehaviour
{
    public int speed = 5;
    public int life;
    public int score = 0;
    public bool isCollided = false;
    Vector3 startPoint = new Vector3(-9.4f, 1.4f, -11);

    private bool dirty = false;
    private bool time = false;
    private int maxLife = 3;
    private float remainTime = 10f;

    public NavMeshAgent meshAgent;

    // Start is called before the first frame update
    void Start()
    {
        life = maxLife;
        transform.position = startPoint;
        speed = 5;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("speedItem")){
            speed = 8;
            dirty = true;
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("lifeItem"))
        {
            life++;
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("stunItem"))
        {
            meshAgent.gameObject.SetActive(false);
            time = true;
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Enemy"))
        {
            life--;
            transform.position = startPoint;
            isCollided = true;
        }
        if (other.CompareTag("Coin"))
        {
            score++;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Goal"))
        {
            //Game Finished
            SceneManager.LoadScene(3);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (life == 0)
        {
            SceneManager.LoadScene(4);
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

        if (time)
        {
            if(remainTime > 0)
            {
                remainTime -= Time.deltaTime;
            }
            if(remainTime <= 0)
            {
                meshAgent.gameObject.SetActive(true);
                time = false;
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
            transform.Rotate(Vector3.down * Time.deltaTime *110);
        }
        if (Input.GetKey("s")) //walk backwards
        {
            transform.position += (-transform.forward) * Time.deltaTime * speed;
        }
        if (Input.GetKey("d"))//walk right
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 110);
        }
    }
}
