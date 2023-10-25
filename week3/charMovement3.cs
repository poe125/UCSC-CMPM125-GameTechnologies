using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMovement3 : MonoBehaviour
{
    private bool selected = false;
    public chardecide charDecide;
    public bool gameover3 = false;
    public bool savePoint3 = false;
    public int speed3 = 9;

    public Transform BulletSpawnPoint;
    public GameObject BulletPrefab;
    public float bulletSpeed = 10;

    public AudioClip newTrack;
    private AudioManager theAM;

    // Start is called before the first frame update
    void Start()
    {
        theAM = FindObjectOfType<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("car")) //game end
        {
            transform.position = new Vector3(0, 0, -5);
            gameover3 = true;
        }
        if (other.CompareTag("save"))
        {
            savePoint3 = true;
            if (newTrack != null)
            {
                theAM.ChangeBGM(newTrack);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

       // Debug.Log("Character Number: " + charDecide.characterNumber);

        if (charDecide.characterNumber == 0)
        {
            //      null
        }
        else if (charDecide.characterNumber == 3)
        {
            if (!savePoint3)
            {
                if (!selected)
                {
                    transform.position = new Vector3(0, 0, -5);
                    selected = true;
                }

                if (Input.GetKey("w"))//walk forward
                {
                    transform.position += Vector3.forward * Time.deltaTime * speed3;
                }
                if (Input.GetKey("s")) //walk backwards
                {
                    transform.position += Vector3.back * Time.deltaTime * speed3;
                }
            }
            else
            {
      
                    //show "shoot the balloons!"
                    transform.position = new Vector3(0, 0, 38);
                          }
        }
        else
        {
            Destroy(gameObject, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.forward * bulletSpeed;
        }
    }
}
