using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WinRoomExit : RoomExit
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene(0);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        //_camera.transform.position = new Vector3(nextCamera.position.x, nextCamera.position.y, _camera.transform.position.z);
        //_player.transform.position = new Vector3(nextSpawn.position.x, nextSpawn.position.y, _player.transform.position.z);
    }
}
