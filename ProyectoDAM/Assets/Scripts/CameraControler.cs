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
