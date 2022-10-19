using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private float temps = 0;
    private int direction = 1;

    private int distMin = 1;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //temps += Time.deltaTime;
        //if(temps> 1)
        //{
        //    temps = 0;
        //    direction *= -1;
        //}

        //transform.position += new Vector3(2*direction, 0, 0)*Time.deltaTime;

        if (player)
        {
            transform.LookAt(player.transform.position);

            if (Vector3.Distance(transform.position, player.transform.position) >= distMin)
            {
                transform.position += transform.forward * 2 * Time.deltaTime;
            }
        }
    }
}
