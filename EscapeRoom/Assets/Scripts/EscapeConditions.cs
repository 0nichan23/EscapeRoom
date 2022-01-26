using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeConditions : MonoBehaviour
{
    private SpriteRenderer rend;
    private GameObject key;
    bool drawerOpen = false;
    public Color _color;
    public Color alphaColor;
    public bool codeIsTrue = false;
    void Awake()    
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        key = GameObject.Find("Key");        
    }

   


    private void OnMouseDown()
    {
        drawerOpen = !drawerOpen;
        if (Input.GetMouseButton(0))
        {
            if (gameObject.tag == "Picture")
            {
                gameObject.AddComponent<Rigidbody>();
                gameObject.transform.rotation = new Quaternion(-0.14f, 0.40f, 0.29f, 0.85f);               
            }
            if (gameObject.tag == "Case")
            {
                if (codeIsTrue)
                {
                    gameObject.GetComponent<SpriteRenderer>().color = alphaColor;
                }
            }
            if (gameObject.tag == "Normal")
            {
                gameObject.GetComponent<SpriteRenderer>().color = alphaColor; 
            }                       
        }       
    }

   


}
