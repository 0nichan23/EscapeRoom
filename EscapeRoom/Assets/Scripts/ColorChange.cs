using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public GameManager gameManager;
    public Renderer rend;
    public GameObject drawner;
    public GameObject secondDrawner;
    bool drawnerOpen = false;
    void Start()    
    {
        rend = GetComponent<Renderer>();
    }

    void OnMouseEnter()
    {
        rend.material.color = Color.red;

    }

    void OnMouseOver()
    {



    }

    private void OnMouseDown()
    {
        drawnerOpen = !drawnerOpen;
        
        if (Input.GetMouseButton(0))
        {
            if (drawnerOpen)
            {
                drawner.SetActive(true);
                secondDrawner.SetActive(true);
            }

            else
            {
                drawner.SetActive(false);
                secondDrawner.SetActive(false);

            }
        }
        
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        rend.material.color = Color.white;

    }


}
