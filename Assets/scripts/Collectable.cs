using UnityEngine;
using System.Collections;


public interface ICollectable
{
    int ItemID { get; }
}

public class Collectable : MonoBehaviour, ICollectable
{
    // -------------------------------------------------------------------------------------
    // @ PUBLIC
    // -------------------------------------------------------------------------------------
    public int ItemID => _itemID;

    // -------------------------------------------------------------------------------------
    // @ PRIVATE
    // -------------------------------------------------------------------------------------
    // Use this for initialization
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

    [SerializeField]
    private int _itemID = 0;
}
