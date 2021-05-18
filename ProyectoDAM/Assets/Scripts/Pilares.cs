using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilares : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _spriteRenderer.color = new Color(1f, 1f, 1f, .75f);
    }
}