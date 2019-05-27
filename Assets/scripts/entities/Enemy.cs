using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    private WeaponSlot[] _weaponSlots;
    public Transform avatar;

    
    private HealthBar _healthBar;

    [Header("Health Bar Settings")]
    public Color restColor = Color.yellow;
    public Color alarmColor = Color.red;

    
    private bool _lookAtPlayer = false;

    private void Awake()
    {
        _healthBar = GetComponentInChildren<HealthBar>();
        player = GameObject.FindWithTag("player");
        _weaponSlots = GetComponentsInChildren<WeaponSlot>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _healthBar.Color = restColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (_lookAtPlayer)
        {
            avatar.rotation = Quaternion.Euler(new Vector3(transform.localRotation.x,
                transform.localRotation.y,
                axeDeTire()));
        }
    }

    private float axeDeTire()
    {
        Vector2 positionJoueur = player.transform.position;
        Vector2 positionEnemie = transform.position;
        Vector2 trajetBale = positionJoueur - positionEnemie;

        trajetBale.Normalize();
        float rotationEnemie = Mathf.Atan2(trajetBale.y, trajetBale.x) * Mathf.Rad2Deg - 90.0f;

        return rotationEnemie;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            foreach (WeaponSlot weaponSlot in _weaponSlots)
            {
                weaponSlot.Item.Fire(Vector2.zero);
            }
            
            _lookAtPlayer = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            _healthBar.Color = alarmColor;
//            _lookAtPlayer = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            _healthBar.Color = restColor;
            _lookAtPlayer = false;
        }
    }

}
