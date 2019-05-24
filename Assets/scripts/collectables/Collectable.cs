using UnityEngine;
using System.Collections;



public enum ItemType
{
    Weapon,
    Ammo
}

public class Collectable : MonoBehaviour
{
    // -------------------------------------------------------------------------------------
    // @ PUBLIC
    // -------------------------------------------------------------------------------------
    public ItemType ItemType => _itemType;

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
    private ItemType _itemType = 0;


    //[SerializeField]
    //private Item_2 _item;
}
