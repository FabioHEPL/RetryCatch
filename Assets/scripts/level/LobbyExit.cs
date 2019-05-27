using UnityEngine;
using System.Collections;

public class LobbyExit : RoomExit
{
    private void OnMouseDown()
    {
        _camera.transform.position = new Vector3(nextCamera.x, nextCamera.y, _camera.transform.position.z);
        _player.transform.position = new Vector3(nextSpawn.x, nextSpawn.y, _player.transform.position.z);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        //_camera.transform.position = new Vector3(nextCamera.position.x, nextCamera.position.y, _camera.transform.position.z);
        //_player.transform.position = new Vector3(nextSpawn.position.x, nextSpawn.position.y, _player.transform.position.z);
    }
}
