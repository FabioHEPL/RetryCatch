using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public GameObject Item
    {
        get => _item;
        set => _item = value;
    }

    public ItemType itemType;

    public string InputName
    {
        get => _inputName;
    }


    public bool isEmpty()
    {
        return transform.childCount == 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField]
    private GameObject _item = null;

    [SerializeField]
    private string _inputName = "";
}
