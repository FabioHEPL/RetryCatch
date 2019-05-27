using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action Died;
    private Life _life;

    private void Awake()
    {
        _inventory = GameObject.FindWithTag("inventory").GetComponent<Inventory>();
        _life = GetComponent<Life>();
    }

    private void OnLifeDied()
    {
        // drop all items in inventory
        // 1. drop all guns
        // 2. drop gun in weapon slot (if any)
        // 3. drop ammo in same amount
        _inventory.Reset();
        _weaponSlot.Reset();
        Reset();

        Died?.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // For every slot, check if contains a weapon
        // if it does, select that weapon
        foreach (Slot slot in _inventory.Slots)
        {            
            if (Input.GetButtonDown(slot.InputName))
            {               
                if (!slot.isEmpty())
                {
                    Weapon weapon = slot.Item.GetComponent<Weapon>();
                    if (weapon != null)
                    {
                        if (!_weaponSlot.isEmpty())
                        {
                            _inventory.AddWeapon(_weaponSlot.Item);
                        }

                        _weaponSlot.Item = weapon;
                    }
                }
            }
        }

        if (Input.GetButtonDown("Fire1") && !_weaponSlot.isEmpty())
        {
            if (_weaponSlot.Item.Ammo > 0)
            {
                Vector2 positionSouris = Helper.mousePosition();
                Vector2 positionActuelle = (Vector2)_weaponSlot.Item.transform.position;
                _weaponSlot.Item.Fire(positionSouris - positionActuelle);
            }
        }
    }

    private void OnEnable()
    {
        _inventory.OnAmmoCollected += OnInventoryAmmoCollected;
        _inventory.OnWeaponCollected += OnInventoryWeaponCollected;
        _life.Died += OnLifeDied;
    }

    private void OnDisable()
    {
        _inventory.OnAmmoCollected -= OnInventoryAmmoCollected;
        _inventory.OnWeaponCollected -= OnInventoryWeaponCollected;
        _life.Died -= OnLifeDied;
    }

    private void OnInventoryAmmoCollected(Ammo ammo)
    {
        if (!_weaponSlot.isEmpty() && _weaponSlot.Item.ID == ammo.WeaponID)
        {
            _weaponSlot.Item.Ammo += ammo.Amount;
        }
    }

    private void OnInventoryWeaponCollected(Weapon weapon)
    {
        if (_weaponSlot.isEmpty())
            _weaponSlot.Item = weapon;
    }

    public void Reset()
    {
        _life.Health = _life.maxHealth;
        //Debug.Log(_life.Health);
    }

    [SerializeField]
    private WeaponSlot _weaponSlot;

    //[SerializeField]
    private Inventory _inventory;
}
