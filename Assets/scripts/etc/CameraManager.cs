using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Camera _camera;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        // on trigger entered, get camera position in room (parent object-
        Vector3 cameraPositionInRoom = collision.transform.parent.position;
        Debug.Log(collision.transform.parent.name);
        _camera.transform.position = cameraPositionInRoom;
    }
}
