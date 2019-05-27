using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //[SerializeField]
    private Boss _boss;

    //[SerializeField]
    private Player _player;

    protected GameObject _camera;


    [Header("Lobby Room")]
    public Transform lobbyRoomCamera;
    public Transform lobbyRoomSpawn;
    public TextMeshPro lobbyText;

    [Header("Win Room")]
    public Transform winRoomCamera;
    public Transform winRoomSpawn;

    [Header("Player")]
    public GameObject playerPrefab;

    [Header("Rooms to reset")]
    public PrefabMap[] rooms;

    void Awake()
    {
        _camera = GameObject.FindWithTag("MainCamera");
        _player = GameObject.FindWithTag("player").GetComponent<Player>();
        _boss = GameObject.FindWithTag("boss").GetComponent<Boss>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        _player.Died += OnPlayerDied;
        _boss.Died += OnBossDied;
    }

    private void OnDisable()
    {
        _player.Died -= OnPlayerDied;
        _boss.Died -= OnBossDied;
    }

    private void OnBossDied()
    {
        _camera.transform.position = new Vector3(winRoomCamera.position.x, winRoomCamera.position.y, _camera.transform.position.z);
        _player.transform.position = new Vector3(winRoomSpawn.position.x, winRoomSpawn.position.y, 0f);
    }

    private void OnPlayerDied()
    {
        _camera.transform.position = new Vector3(lobbyRoomCamera.position.x, lobbyRoomCamera.position.y, _camera.transform.position.z);
        // Instantiate(playerPrefab, new Vector3(lobbyRoomSpawn.position.x, lobbyRoomSpawn.position.y, 0f), Quaternion.identity);
        _player.transform.position = new Vector3(lobbyRoomSpawn.position.x, lobbyRoomSpawn.position.y, 0f);
        _player.Reset();

        // change lobby title
        lobbyText.text = "RETRY";

        for (int i = 0; i < rooms.Length; i++)
        {
            GameObject room = Instantiate(rooms[i].prefab, rooms[i].transform.position, rooms[i].transform.rotation);
            Destroy(rooms[i].transform.gameObject);
            rooms[i].transform = room.transform;
        }

        ResetReferences();
    }

    void ResetReferences()
    {
        Transform boss;
        for (int i = 0; i < rooms.Length; i++)
        {
            boss = rooms[i].transform.Find("entities/boss");
            if (boss != null)
            {                
                _boss = boss.GetComponent<Boss>();
                _boss.gameObject.name = "YOOOOOOOP";
                _boss.Died += OnBossDied;
            }
        }
    }
}

[System.Serializable]
public class PrefabMap
{ 
    public GameObject prefab;
    public Transform transform;
}