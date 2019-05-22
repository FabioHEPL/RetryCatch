using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Helper.mousePosition() - (Vector2)transform.position;
        direction.Normalize();

        float zRotation = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.eulerAngles =  new Vector3(0.0f, 0.0f, zRotation);
    }




}
