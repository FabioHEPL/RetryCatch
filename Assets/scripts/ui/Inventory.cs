 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{
    public event Action<Ammo> OnAmmoCollected;
    public event Action<Weapon> OnWeaponCollected;

    public List<Slot> Slots
    {
        get => _slots;
    }

    private void Awake()
    {
        // Create slot list
        foreach (Transform t in transform)
        {
            Slot slot = t.GetComponent<Slot>();
            if (slot != null)
                _slots.Add(slot);            
        }


       // slots.Reverse();
    }

    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CollectItem(GameObject item)
    {
        CollectItem(item.GetComponent<Collectable>());
    }

    public void CollectItem(Collectable item)
    {
        switch (item.ItemType)
        {
            case ItemType.Weapon:
                Weapon weapon = item.GetComponent<Weapon>();
                AddWeapon(weapon);
                OnWeaponCollected?.Invoke(weapon);
                break;
            case ItemType.Ammo:
                Ammo ammo = item.GetComponent<Ammo>();
                AddAmmo(ammo);
                OnAmmoCollected?.Invoke(ammo);
                break;          
            
        }
    }

    public void AddWeapon(Weapon weapon)
    {
        GameObject item = weapon.gameObject;

        foreach (Slot slot in _slots)
        {
            if (slot.isEmpty())
            {
                slot.Item = item;
                item.transform.parent = slot.gameObject.transform;
                item.transform.localPosition = new Vector3(0, 0, slot.gameObject.transform.localPosition.z);
                item.transform.localRotation = Quaternion.identity;
                item.transform.localScale = new Vector3(slotScale.x, slotScale.y, 1);
                break;
            }
        }
    }

    public void AddAmmo(Ammo ammo)
    {
        foreach (Slot slot in _slots)
        { 
            if (!slot.isEmpty())
            {                
                Weapon weapon = slot.Item.GetComponent<Weapon>();
                if (weapon.ID == ammo.WeaponID)
                {
                    weapon.Ammo += ammo.Amount;
                    break;
                }                
            }
        }

        Destroy(ammo.gameObject);
    }


    public void Reset()
    {
        foreach (Slot slot in _slots)
        {
            slot.Reset();
        }

    }

    private List<Slot> _slots = new List<Slot>();
    [SerializeField]
    private Vector2 slotScale;
}
