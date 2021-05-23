using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public int speed;
    Transform playerT;

    private float _cameraX;

    void Start()
    {
        playerT = FindObjectOfType<PlayerControler>().transform;
    }

    void LateUpdate()
    {
        if (playerT == null)
            return;

        _cameraX = Mathf.Clamp(playerT.position.x, -580, 60);
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(_cameraX, transform.position.y, transform.position.z), speed * Time.deltaTime);
    }
}


/*
public int speed;
GameObject player;
Vector3 vel = Vector3.zero;
bool limite = false; //Si limite es true, la cámara se detiene

void Start()
{
    player = GameObject.FindGameObjectWithTag("Player1");
}


void FixedUpdate()
{
    Vector3 posPlayer = player.transform.position;

    if (limite == false)
    {
        transform.position = Vector3.SmoothDamp(transform.position, posPlayer, ref vel, 0); //Cámara sigue al personaje suavemente
    }

    if (posPlayer.x < -580 || posPlayer.x > 60)  //controla los límites laterales de la cámara con el escenario
    {
        limite = true;
    } else if (posPlayer.x >=-580 &&  posPlayer.x <= 60)
    {
        limite = false;
    }
}
}
*/
