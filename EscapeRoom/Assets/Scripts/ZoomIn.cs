using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour
{
    
    private Vector3 defaultCameraPos;
    public Transform cameraZoom;

    private void Awake()
    {
        defaultCameraPos = Camera.main.transform.position;
    }

    void OnMouseEnter()
    {
        MouseEnter();
    }


    void OnMouseExit()
    {
        MouseExit();
    }

    public void MouseExit()
    {

        Camera.main.transform.position = defaultCameraPos;
        Camera.main.orthographicSize = 5;
        Camera.main.GetComponent<CameraMovement>().enabled = true;
    }

    public void MouseEnter()
    {
        Camera.main.transform.position = cameraZoom.position;
        Camera.main.orthographicSize = 0.45f;
        Camera.main.GetComponent<CameraMovement>().enabled = false;

    }
}
