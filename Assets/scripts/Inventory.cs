using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Slot> slots;

    private void Awake()
    {
        // Create slot list
        foreach (Transform t in transform)
        {
            Slot slot = t.GetComponent<Slot>();
            if (slot != null)
                slots.Add(slot);            
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

    public void AddItem(GameObject item)
    {
        foreach (Slot slot in slots)
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

    [SerializeField]
    private Vector2 slotScale;
}
