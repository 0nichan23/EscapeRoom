using UnityEngine;

public class moveObject : Interacteble
{
    public float dragSpeed;
    private Vector3 dragOrigin;
    public bool cameraDragging = true;
    public float outerLeft = -10f;
    public float outerRight = 10f;
    public GameObject hiddenBehind;
    bool isToching;
    void Update()
    {
        if (cameraDragging)
        {

            if (Input.GetMouseButtonDown(1))
            {
                dragOrigin = Input.mousePosition;
                return;
            }

            if (!Input.GetMouseButton(1)) return;

            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
            Vector3 move = new Vector3(pos.x * dragSpeed, 0, 0);

            if (move.x > 0f)
            {
                if (this.transform.position.x < outerRight)
                {
                    transform.Translate(move, Space.World);
                }
            }
            else
            {
                if (this.transform.position.x > outerLeft)
                {
                    transform.Translate(move, Space.World);
                }
            }
        }
        if (!isToching)
        {
            hiddenBehind.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject)
        {
            isToching = false;
        }
        else
        {
            isToching = true;
        }
    }

    void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().material.color = Color.green;
    }

    void OnMouseExit()
    {

        GetComponent<SpriteRenderer>().material.color = Color.white;

    }

    public override void Interact()
    {
    }
}