using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
    {
    public int speed;
    Vector3 target;
    Vector3 posToGo;

    void Start()
    {
        target = transform.position;
        //gameObject.GetComponent<Transform>().position = new Vector3(20, 0, 0);
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x + 20, gameObject.transform.position.y, gameObject.transform.position.z);
        //puntero = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        posToGo = new Vector3(target.x, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, posToGo, speed * Time.deltaTime);

        if (posToGo.x < gameObject.transform.position.x) //movimiento hacía la izquierda
        {
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (target.x > gameObject.transform.position.x) //movimiento hacía la derecha
        {
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

            if (transform.position == posToGo)
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }
    }
}
/*if (this.gameObject.transform.position.x == target.x)
{
    this.gameObject.transform.position = new Vector3(target.x, 0, 0);
}*/

//gameObject.transform.position = new Vector3(gameObject.transform.position.x + 50f * Time.deltaTime, gameObject.transform.position.y, gameObject.transform.position.z);
//gameObject.transform.Translate(50f*Time.deltaTime, 0, 0);

/* //OLD
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
    gameObject.transform.Translate(-speed * Time.deltaTime, 0, 0);
    gameObject.GetComponent<Animator>().SetBool("moving", true);
    gameObject.GetComponent<SpriteRenderer>().flipX = false;
}
else if (target.x > gameObject.transform.position.x) //movimiento hacía la derecha
{
    gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
    gameObject.GetComponent<Animator>().SetBool("moving", true);
    gameObject.GetComponent<SpriteRenderer>().flipX = true;
}


if ((gameObject.transform.position.x == target.x)) //parado
{
    gameObject.transform.Translate(0, 0, 0);
    gameObject.transform.position = new Vector3(target.x, 0, 0);
    gameObject.GetComponent<Animator>().SetBool("moving", false);
}
}  
} */





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