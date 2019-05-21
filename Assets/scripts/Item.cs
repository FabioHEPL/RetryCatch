using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem
{
    int ID { get; }
    string Name { get; }
}

public class Item : IItem
{
    // -------------------------------------------------------------------------------------
    // @ PUBLIC
    // -------------------------------------------------------------------------------------
    public int ID => _id;
    public string Name => _name;

    // -------------------------------------------------------------------------------------
    // @ PRIVATE
    // -------------------------------------------------------------------------------------
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

    [SerializeField]
    private int _id;
    [SerializeField]
    private string _name;
}



