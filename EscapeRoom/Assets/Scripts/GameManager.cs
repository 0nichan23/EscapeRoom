using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;


    public GameObject Inventory;
    public static GameManager Instance { get { return _instance; } }

    bool inventoryActive = false;
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }


    public Camera _camera;
    public Transform[] roomCameras;
    //[HideInInspector]
    public int i = 0;
    private void Update()
    {

       Transform currentPos = roomCameras[i];
       Quaternion currnetRot = roomCameras[i].rotation;

        _camera.transform.position = new Vector3(currentPos.transform.position.x, currentPos.transform.position.y, currentPos.transform.position.z);
        _camera.transform.rotation = currnetRot;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            BtnNext();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BtnPrev();
        }
    }

    public void BtnNext()
    {

        if (i + 1 < roomCameras.Length)
        {
            i++;
        }

    }

    public void BtnPrev()
    {

        if (i - 1 >= 0)
        {
            i--;
        }
    }
        
    public void ToggleInventory()
    {
        inventoryActive = !inventoryActive;

        if (inventoryActive)
        {
            Inventory.SetActive(true);
        }

        else
        {
            Inventory.SetActive(false);

        }
    }

    public void ChooseCamera(int cameraChooser)
    {
        cameraChooser = i;
    }
}
