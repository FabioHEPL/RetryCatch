using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject player;
    public WeaponSlot weaponSlot;
    public int health = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(transform.localRotation.x,
            transform.localRotation.y,
            axeDeTire()));
    }

    private float axeDeTire()
    {
        Vector2 positionJoueur = player.transform.position;
        Vector2 positionEnemie = transform.position;
        Vector2 trajetBale = positionJoueur - positionEnemie;

        trajetBale.Normalize();
        float rotationEnemie = Mathf.Atan2(trajetBale.y, trajetBale.x) * Mathf.Rad2Deg - 90.0f;

        return rotationEnemie;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            weaponSlot.Item.Fire(Vector2.zero);            
        }
    }
}
