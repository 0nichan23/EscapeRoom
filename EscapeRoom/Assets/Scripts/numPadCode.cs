using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class numPadCode : Interacteble
{
    public string codeTextValue;
    public string passcode;
    public bool passCodeIsTrue = false;
    public Interacteble itemInside;
    
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
        AudioManager.Instance.Play(gameObject.GetComponents<AudioSource>()[0].clip);
        Interact();
    }
    public override void Interact()
    {
        if (codeTextValue.Length == 4)
        {
            if (codeTextValue == passcode)
            {
                itemInside.gameObject.SetActive(true);
                AudioManager.Instance.Play(gameObject.GetComponents<AudioSource>()[1].clip);
                gameObject.GetComponent<ZoomIn>().MouseExit();
                Destroy(gameObject.GetComponent<ZoomIn>());
                
            }
            else
            {
                codeTextValue = "";
                AudioManager.Instance.Play(gameObject.GetComponent<AudioSource>().clip);
                AudioManager.Instance.Play(gameObject.GetComponents<AudioSource>()[2].clip);

            }
        }
    }
}
