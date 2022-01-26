using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class numPadCode : Interacteble
{
    public string codeTextValue = "";
    public string passcode;
    public Interacteble itemInside;
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
        Interact();
    }

    public override void Interact()
    {
        if (codeTextValue.Length == 4)
        {
            if (codeTextValue == passcode)
            {
                itemInside.gameObject.SetActive(true);
            }
            else
            {
                codeTextValue = "";
            }
        }
    }


}
