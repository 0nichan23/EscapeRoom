using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private SpriteRenderer rend;
    private GameObject key;
    bool drawnerOpen = false;
    public Color _color;
    public Color alphaColor;
    public GameObject child;
    void Awake()    
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        key = GameObject.Find("Key");
        
    }

    void OnMouseEnter()
    {
        rend.material.color = _color;
        if (gameObject.tag == "Picture")
            key.SetActive(false);
    }

    void OnMouseOver()
    {



    }

    private void OnMouseDown()
    {
        drawnerOpen = !drawnerOpen;
        if (Input.GetMouseButton(0))
        {
            if (gameObject.tag == "Picture")
            {
                gameObject.AddComponent<Rigidbody>();
                gameObject.transform.rotation = new Quaternion(-0.14f, 0.40f, 0.29f, 0.85f);
                key.SetActive(true);
            }
            if (gameObject.tag == "Case")
            {
                gameObject.GetComponent<SpriteRenderer>().color = alphaColor;
            }
            child.SetActive(true);
            
            
        }
        
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        rend.material.color = Color.white;

    }


}
