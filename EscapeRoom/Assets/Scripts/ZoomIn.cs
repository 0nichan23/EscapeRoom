using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour
{
    public Renderer rend;
    public GameManager gameManager;
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void OnMouseEnter()
    {
        rend.material.color = Color.red;   
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            GameManager.Instance.i = 3;
        }
    }

    void OnMouseExit()
    {
        rend.material.color = Color.white;

    }
}
