using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    [SerializeField]
    public Camera _camera;
    [SerializeField]
    public GameObject _icon;

    private void Awake()
    {       
     
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void OnGUI()
    {

    }

    private void LateUpdate()
    {
  
    }

    private void Update()
    {
        transform.position = Helper.mousePosition();
    }
}