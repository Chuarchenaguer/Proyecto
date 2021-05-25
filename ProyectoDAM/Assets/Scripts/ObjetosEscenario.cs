using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjetosEscenario : MonoBehaviour
{
    public PointerControl pointerControl;
    Transform playerT;

    void Start()
    {
        //playerT = FindObjectOfType<PlayerControler>().transform.position;
        gameObject.GetComponent<Animator>().SetBool("open", false);

    }

    private void Update()
    {
        //playerT = new Vector3(playerT.position.x, transform.position.y, transform.position.z);
        //Debug.Log(playerT.position.x+"-----"+ gameObject.transform.position.x);
    }
    
    public void OnMouseEnter()
    {
        pointerControl.changeCursor("pick");
        Debug.Log("dentro");
    }
    public void OnMouseExit()
    {
        pointerControl.changeCursor("normal");
        Debug.Log("fuera");
    }
    //public void OnMouseDown()
    //{
        //if (playerT.position == transform.position)
        //{
            //gameObject.GetComponent<Animator>().SetBool("open", true);
        //}
    //}
}

/*
public string desc1;
public bool hasDesc;
public TextMesh textObject;
public Renderer rend;

// Start is called before the first frame update
void Start()
{

    if (hasDesc)
    {
        textObject.GetComponent<TextMesh>().text = desc1;
    }
}

// Update is called once per frame
void Update()
{
}


void OnMouseOver()
{
    Debug.Log("hola");
    //rend = GetComponent<Renderer>();
    if (hasDesc)
    {
        textObject.GetComponent<TextMesh>().text = desc1;
    }
}
void OnMouseExit()
{
    Debug.Log("adios");
    //rend = GetComponent<Renderer>();
    if (hasDesc)
    {
        textObject.GetComponent<TextMesh>().text = "";
    }
}

public void OnPointerEnter(PointerEventData eventData)
{
    Debug.Log("hola");
}
}*/
