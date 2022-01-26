using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class numPadCode : MonoBehaviour
{
    [SerializeField]

    public string codeTextValue = "";
    public EscapeConditions colorChange;
    public GameObject buttons;
    bool isToching;
    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<BoxCollider2D>().enabled == false)
        {
            buttons.SetActive(false);
        }
        else
        {
            buttons.SetActive(true);
        }

        if (codeTextValue == "1352")
        {
            colorChange.codeIsTrue = true;
            Debug.Log("Code Is TRUE");
        }

        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
            Debug.Log("Code Is FALSE, RESTART");
        }

    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }


}
