using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{

    public int speed;
    GameObject player;
    Vector3 vel = Vector3.zero;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player1");
    }

    
    void FixedUpdate()
    {
        Vector3 posPlayer = player.transform.position;

        transform.position = Vector3.SmoothDamp(transform.position, posPlayer, ref vel, 0.15f);
        
    }
}
