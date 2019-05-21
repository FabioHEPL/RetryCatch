using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollection<T>
{
    void AddElement(T element);
    T RemoveElement(int id);
    T[] Elements { get; }
}

public class Inventory : MonoBehaviour, ICollection<Item>
{
    // -------------------------------------------------------------------------------------
    // @ PUBLIC
    // -------------------------------------------------------------------------------------
    public void AddElement(Item element)
    {
        _elements.Add(element);
    }    

    public Item RemoveElement(int id)
    {
        Item element = _elements[id];
        _elements.RemoveAt(id);

        return element;
    }

    public void AddElement(int itemID)
    {
        switch (itemID)
        {
            case 0:
                //AddElement(new Weapon());
                break;
            case 1:
                break;
            case 2:
                break;
        }
    }

    public Item[] Elements => _elements.ToArray();
    // -------------------------------------------------------------------------------------
    // @ PRIVATE
    // -------------------------------------------------------------------------------------
    private void Awake()
    {
        _elements = new List<Item>();
    }

    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

    [SerializeField]
    private List<Item> _elements;
}


