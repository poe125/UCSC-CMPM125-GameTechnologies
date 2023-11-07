using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Interval : MonoBehaviour
{
    public GameObject canvasTrigger;
    public GameObject canvasTrigger2;
    public GameObject canvasTrigger3;
    int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        canvasTrigger.SetActive(false);
        canvasTrigger2.SetActive(false);
        canvasTrigger3.SetActive(false);
    }

    public void Awake()
    {
        canvasTrigger = GameObject.FindWithTag("canvas");
        canvasTrigger2 = GameObject.FindWithTag("canvas2");
        canvasTrigger3 = GameObject.FindWithTag("canvas3");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("warp"))
        {
            //Game start
            SceneManager.LoadScene(2);
        }
        if (other.CompareTag("trigger"))
        {
            canvasTrigger.SetActive(true);
            canvasTrigger2.SetActive(false);
            canvasTrigger3.SetActive(false);
        }
        if (other.CompareTag("trigger2"))
        {
            canvasTrigger.SetActive(false);
            canvasTrigger2.SetActive(true);
        }
        if (other.CompareTag("trigger3"))
        {
            canvasTrigger2.SetActive(false);
            canvasTrigger3.SetActive(true);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))//walk forward
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
    }
}
