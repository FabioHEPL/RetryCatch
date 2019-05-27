using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomExit : MonoBehaviour
{
    public Vector3 nextSpawn;
    public Vector3 nextCamera;
    protected GameObject _camera;
    protected GameObject _player;

    protected virtual void Awake()
    {
        _camera = GameObject.FindWithTag("MainCamera");
        _player = GameObject.FindWithTag("player");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        _camera.transform.position = new Vector3(nextCamera.x, nextCamera.y, _camera.transform.position.z);
        _player.transform.position = new Vector3(nextSpawn.x, nextSpawn.y, _player.transform.position.z); 
    }
}
