using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjetosEscenario : MonoBehaviour//, IPointerEnterHandler, IPointerExitHandler
{
    public PointerControl pointerControl;

    /*
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        pointerControl.changeCursor("pick");
        Debug.Log("dentro");
    }
    public void OnPointerExit(PointerEventData PointerEventData)
    {
        pointerControl.changeCursor("normal");
        Debug.Log("fuera");
    }
}*/

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
