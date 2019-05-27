using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 10.0f;
    public float collisionRadius = 1f;
    public float collisionDistance = 0.25f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float inputx = Input.GetAxis("Horizontal");
        float inputy = Input.GetAxis("Vertical");
        Vector2 getaxis = new Vector2(inputx, inputy);

        RaycastHit2D hit2D = Physics2D.CircleCast((Vector2)transform.position, collisionRadius, getaxis, collisionDistance, LayerMask.GetMask("wall"));
      //  Debug.DrawRay((Vector2)transform.position, getaxis * 5, Color.blue);
        //Debug.DrawLine((Vector2)transform.position, getaxis * 5, Color.green);

        if (!hit2D)
            Move(getaxis);

    }

    public void Move(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
