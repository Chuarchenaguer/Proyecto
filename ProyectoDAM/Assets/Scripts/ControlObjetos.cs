using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlObjetos : MonoBehaviour
{
    public List<GameObject> InvObj = new List<GameObject>();

    public void AddObj (GameObject obj) //Para añadir los objetos al inventario
    {
        InvObj.Add(obj);
    }

    public void DropObj (GameObject obj)  //Para destruir objetos que ya no se van a usar más
    {
        InvObj.Remove(obj);
    }

    public bool HaveObj (GameObject obj)  //Devuelve true o false si tenemos el objeto o no
    {
        return InvObj.Contains(obj); 
    }
}
