using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public abstract void Fire(Vector2 direction);
    public abstract int Ammo { get; set; }
    public abstract int ID { get; }
}
