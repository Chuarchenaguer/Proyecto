using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerControl : MonoBehaviour
{
    public int pointerSize = 64;
    public Texture2D normalCursor, pickCursor, doorCursor, EyeCursor;
    Texture2D activeCursor;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        changeCursor("normal");
    }

    public void changeCursor(string typeCursor)
    {
        if (typeCursor == "normal")
        {
            activeCursor = normalCursor;
        }
        if (typeCursor == "pick")
        {
            activeCursor = pickCursor;
        }
    }
    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(Input.mousePosition.x, Screen.height - Input.mousePosition.y, pointerSize, pointerSize), activeCursor);
    }
}
