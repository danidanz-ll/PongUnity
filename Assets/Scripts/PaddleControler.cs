using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControler : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    private float paddleHeight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        //left paddle keycodes
        KeyCode upCode = KeyCode.W;
        KeyCode downCode = KeyCode.S;

        if (transform.localPosition.x > 0)
        {
            upCode = KeyCode.UpArrow;
            downCode = KeyCode.DownArrow;
        }

        if (Input.GetKey(upCode))
        {
            rb.velocity = Vector2.up;
        }
        else if (Input.GetKey(downCode))
        {
            rb.velocity = Vector2.down;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

    }

    private void LateUpdate()
    {
        float topBound = 1 - (paddleHeight / 2) - 0.05f;
        float bottomBound = -topBound;

        var curPos = transform.localPosition;
        float y = Mathf.Clamp(curPos.y, bottomBound, topBound);
        transform.localPosition = new Vector2(curPos.x, y);
    }
}
