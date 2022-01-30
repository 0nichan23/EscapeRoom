using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class NumPadCode : Interacteble
{
    public string codeTextValue = "1352";
    public string passcode;
    public bool passCodeIsTrue = false;
    public Interacteble itemInside;
    public TextMeshProUGUI codeGUI;
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
        Interact();
    }

    public void Update()
    {
        codeGUI.text = codeTextValue;
    }
    public override void Interact()
    {
        if (codeTextValue.Length == 4)
        {
            if (codeTextValue == passcode)
            {
                itemInside.gameObject.SetActive(true);

                gameObject.GetComponent<ZoomIn>().MouseExit();
                Destroy(gameObject.GetComponent<ZoomIn>());
            }
            else
            {
                codeTextValue = "";
            }
        }
    }


}
