using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    public float fireDistance = 2.0f;
    public GameObject bullet;
    public float speed = 20.0f;
    public float cooldown = 1.5f;

    public override void Fire(Vector2 direction)
    {
        if (Time.time >= _lastFire + cooldown)
        {
            Instantiate(bullet, transform.position + transform.up * fireDistance, transform.rotation);
            _lastFire = Time.time;
        }
    }

    public override int Ammo
    {
        get => _ammo;
        set => _ammo = value;
    }
    public override int ID
    {
        get => _id;
    }

    [SerializeField]
    private int _ammo = 10;
    [SerializeField]
    private int _id = 0;

    private float _lastFire;
}
