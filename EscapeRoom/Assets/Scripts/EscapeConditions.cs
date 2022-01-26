using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeConditions : MonoBehaviour
{
    private SpriteRenderer rend;
    private GameObject key;
    bool drawnerOpen = false;
    public Color _color;
    public Color alphaColor;
    public GameObject child;
    public bool codeIsTrue = false;
    void Awake()    
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        key = GameObject.Find("Key");
        
    }

    void OnMouseEnter()
    {
        rend.material.color = Color.green;
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
                if (codeIsTrue)
                {
                    gameObject.GetComponent<SpriteRenderer>().color = alphaColor;
                    child.SetActive(true);
                }
            }
            if (gameObject.tag == "Normal")
            {
                gameObject.GetComponent<SpriteRenderer>().color = alphaColor;
                child.SetActive(true);
            }
            
            
            
        }
        
    }

    void OnMouseExit()
    {
        rend.material.color = Color.white;

    }


}
