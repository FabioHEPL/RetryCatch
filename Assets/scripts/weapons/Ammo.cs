using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   // [SerializeField]
   // private GameObject _bullet = null;

    public int WeaponID { get => _weaponID;  }
    public int Amount { get => _amount; }

    [SerializeField]
    private int _amount = 10;

    [SerializeField]
    private int _weaponID = 0;
}
