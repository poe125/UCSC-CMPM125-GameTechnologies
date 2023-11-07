// Reference; https://www.youtube.com/watch?v=u2EQtrdgfNs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationScript : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    public MainCharacter character;

    Vector3 startPoint = new Vector3(5, 0, 5);

    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPoint; 
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(character.isCollided == true)
        {
            transform.position = startPoint;
            character.isCollided = false;
        }
        agent.destination = player.position;
    }
}
