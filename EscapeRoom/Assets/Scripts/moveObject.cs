using UnityEngine;

public class moveObject : Interacteble
{
    public float dragSpeed;
    private Vector3 dragOrigin;
    public bool passCodeIsTrue = false;
    public float outerLeft = -10f;
    public float outerRight = 10f;
    public GameObject hiddenBehind;
    public bool onObject;
    Collider2D hasCol2D;

    private void Start()
    {
        onObject = false;

        hasCol2D = hiddenBehind.GetComponent<Collider2D>();
    }
    void Update()
    {
        if (onObject)
        {
            if (hasCol2D)
            {
                hasCol2D.enabled = false;
            }

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
        else
        {
            hasCol2D.enabled = true;
        }
    }

    void OnMouseEnter()
    {
        GetComponent<SpriteRenderer>().material.color = Color.green;
    }

    private void OnMouseOver()
    {
        onObject = true;
    }
    void OnMouseExit()
    {

        GetComponent<SpriteRenderer>().material.color = Color.white;
        onObject = false;


    }

    public override void Interact()
    {
    }
}
