using UnityEngine;

public class moveObject : Interacteble
{
    public float dragSpeed;
    private Vector3 dragOrigin;
    public bool passCodeIsTrue = false;
    public float outerLeft;
    public float outerRight;
    public GameObject hiddenBehind;
    public bool onObject;
    Collider2D hasCol2D;
    SpriteRenderer currentColor;

    private void Start()
    {
        onObject = false;
        currentColor = GetComponent<SpriteRenderer>();
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
                if (move.x > outerRight)
                {
                    if (this.transform.position.x < outerRight)
                    {
                        AudioManager.Instance.Play(gameObject.GetComponent<AudioSource>().clip);
                        transform.Translate(move, Space.World);
                    }
                }

            }
            else
            {

                if (this.transform.position.x > outerLeft)
                {
                    AudioManager.Instance.Play(gameObject.GetComponent<AudioSource>().clip);
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
        currentColor.material.color = Color.green;
    }

    private void OnMouseOver()
    {
        onObject = true;
    }
    void OnMouseExit()
    {
        currentColor.material.color = Color.white;
        onObject = false;
    }

    public override void Interact()
    {
    }
}
