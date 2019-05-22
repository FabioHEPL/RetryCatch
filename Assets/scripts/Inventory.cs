using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Slot> slots;

    private void Awake()
    {
        foreach (Transform t in transform)
        {
            slots.Add(t.GetComponent<Slot>());
        }
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
            if (slot.item == null)
            {
                slot.item = item;
                break;
            }
        }
    }
}
