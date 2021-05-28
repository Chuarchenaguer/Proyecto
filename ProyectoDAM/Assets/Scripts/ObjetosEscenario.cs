using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjetosEscenario : MonoBehaviour
{
    public PointerControl pointerControl;


    public void OnMouseEnter()
    {
        pointerControl.changeCursor("pick");
    }
    public void OnMouseExit()
    {
        pointerControl.changeCursor("normal");
    }
}