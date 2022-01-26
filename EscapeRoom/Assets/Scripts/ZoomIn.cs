using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour
{
    
    public Vector3 defaultCameraPos;
    public Transform cameraZoom;

    private void Awake()
    {
        defaultCameraPos = Camera.main.transform.position;
    }

    void OnMouseEnter()
    {
        Camera.main.transform.position =  cameraZoom.position;
        Camera.main.orthographicSize = 0.37f;
    }

    //private void OnMouseDown()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        GameManager.Instance.i = 3;
    //    }
    //}

    void OnMouseExit()
    {
        Camera.main.transform.position = defaultCameraPos;
        Camera.main.orthographicSize = 5;
    }
}
