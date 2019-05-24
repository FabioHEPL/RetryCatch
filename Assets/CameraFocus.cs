using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocus : MonoBehaviour
{
    public Vector3 cameraPosition;
    private GameObject _camera;

    // Start is called before the first frame update
    void Start()
    {
        cameraPosition = transform.position;
        _camera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        _camera.transform.position = cameraPosition;
    }
}
