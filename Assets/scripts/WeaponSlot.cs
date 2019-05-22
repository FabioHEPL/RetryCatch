using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSlot : MonoBehaviour
{
    public Weapon Item
    {
        get => _item;
        set => setItem(value);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool isEmpty()
    {
        return transform.childCount == 0;
    }

    private void setItem(Weapon item)
    {
        _item = item;
        item.transform.parent = transform;
        item.transform.localPosition = new Vector3(0, 0, transform.localPosition.z);
        item.transform.localRotation = transform.localRotation;
        item.transform.localScale = new Vector3(slotScale.x, slotScale.y, 1);
    }

    [SerializeField]
    private Weapon _item = null;


    [SerializeField]
    private Vector2 slotScale;
}
