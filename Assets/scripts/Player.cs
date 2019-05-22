using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // For every slot, check if contains a weapon
        // if it does, select that weapon
        foreach (Slot slot in _inventory.slots)
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
                            _inventory.AddItem(_weaponSlot.Item.gameObject);
                        }

                        _weaponSlot.Item = weapon;
                    }
                }
            }
        }

        if (Input.GetButtonDown("Fire1") && !_weaponSlot.isEmpty())
        {
            Vector2 positionSouris = Helper.mousePosition();
            Vector2 positionActuelle = (Vector2)_weaponSlot.Item.transform.position;
            _weaponSlot.Item.Fire(positionSouris - positionActuelle);
        }
    }

    [SerializeField]
    private WeaponSlot _weaponSlot;

    [SerializeField]
    private Inventory _inventory;
}
