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

    private void Awake()
    {
        if (!isEmpty())
            _item = transform.GetChild(0).GetComponent<Weapon>();
        // TODO:
        //if (_item != null)
        //    setItem(_item);
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

    public void Reset()
    {
        foreach (Transform t in transform)
        {
            Destroy(t.gameObject);
        }

        _item = null;
    }

    //[SerializeField]
    private Weapon _item = null;


    //[SerializeField]
    private Vector2 slotScale = new Vector2(1, 1);
}
