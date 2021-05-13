using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called before the first frame update
    //Vector3 puntero;
    public float speed;
    //public GameObject target;
    Vector3 target;

    void Start()
    {
        //gameObject.GetComponent<Transform>().position = new Vector3(20, 0, 0);
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x + 20, gameObject.transform.position.y, gameObject.transform.position.z);
        //puntero = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (this.gameObject.transform.position.x == target.x)
        {
            this.gameObject.transform.position = new Vector3(target.x, 0, 0);
        }*/

        //gameObject.transform.position = new Vector3(gameObject.transform.position.x + 50f * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
        //gameObject.transform.Translate(50f*Time.deltaTime, 0, 0);
        if (Input.GetMouseButtonUp(0))
        {
            target = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            0f,
            0f
            ));
        }
        if (target.x < gameObject.transform.position.x) //movimiento hacía la izquierda
        {
            this.gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);

        } else if (target.x > gameObject.transform.position.x) //movimiento hacía la derecha
        {
            this.gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
        } else if ((target.x == gameObject.transform.position.x))
        {
            this.gameObject.transform.position = new Vector3(target.x, 0, 0);
        }
    }
}

/*Debug.Log("hgola");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.green);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("hola2");
                if (hit.collider.gameObject.name == "target")
                {
                    Debug.Log("posicion antes" + gameObject.transform.position);
                    gameObject.transform.position = target.transform.position;
                    Debug.Log("posicion despues" + gameObject.transform.position);
                }
            }*/


//gameObject.transform.position = Vector3.MoveTowards(transform.position, target, speed*Time.deltaTime);