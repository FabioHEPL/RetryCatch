using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 1.0f;
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
        Move(getaxis);
    }

    public void Move(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
