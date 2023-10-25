using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    float bulletSpeed = 500;
    public GameObject bullet;

    List<GameObject> bulletList;

    // Start is called before the first frame update
    void Start()
    {
        bulletList = new List<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            GameObject objBullet = (GameObject)Instantiate(bullet);
            //objBullet.SetActive(false);
            Destroy(objBullet);
            bulletList.Add(objBullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Fire()
    {
        for (int i=0; i< bulletList.Count; i++)
        {
            //if the bullet is in use,use a different bullet
            if (!bulletList[i].activeInHierarchy)
            {
                //transform.position of the bullet shooting point
                bulletList[i].transform.position = transform.position;
                bulletList[i].transform.rotation = transform.rotation;
                bulletList[i].SetActive(true);

                Rigidbody tempRigidBodyBullet = bulletList[i].GetComponent<Rigidbody>();
                tempRigidBodyBullet.AddForce(tempRigidBodyBullet.transform.forward * bulletSpeed);
                break;
            }
        }
    }
}
