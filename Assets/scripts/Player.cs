using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Slot slot in _inventory.slots)
        {
            if (slot.item != null)
            {
                Weapon weapon = slot.GetComponent<Weapon>();
                if (weapon != null)
                {
                    _activeWeapon = weapon;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (_activeWeapon != null)
            {
                Vector2 positionSouris = Helper.mousePosition();
                Vector2 positionActuelle = (Vector2)transform.position;
                _activeWeapon.Fire(positionSouris - positionActuelle);
            }
        }

        if (Input.GetButtonDown("Slot 1"))
        {
            if (_inventory.slots[0].item != null)
            {
                Weapon weapon = _inventory.slots[0].item?.GetComponent<Weapon>();
                if (weapon != null)
                    setActiveWeapon(weapon);
            }
        }
        else if (Input.GetButtonDown("Slot 2"))
        {
            if (_inventory.slots[1].item != null)
            {
                Weapon weapon = _inventory.slots[1].item?.GetComponent<Weapon>();
                if (weapon != null)
                    setActiveWeapon(weapon);
            }

        }
        else if (Input.GetButtonDown("Slot 3"))
        {
            if (_inventory.slots[2].item != null)
            {
                Weapon weapon = _inventory.slots[2].item?.GetComponent<Weapon>();
                if (weapon != null)
                    setActiveWeapon(weapon);
            }
        }
    }


    private void setActiveWeapon(Weapon weapon)
    {
        // detach previous weapon 
        if (_activeWeapon != null)
        {
            _activeWeapon.gameObject.SetActive(false);
            _activeWeapon.transform.parent = null;
        }

        weapon.transform.parent = _weaponSlot.transform;
        weapon.transform.localPosition = new Vector3(0, 0, 0);
        weapon.gameObject.SetActive(true);
        _activeWeapon = weapon;

        
    }

    [SerializeField]
    private Weapon _activeWeapon;

    [SerializeField]
    private GameObject _weaponSlot;

    [SerializeField]
    private Inventory _inventory;
}
