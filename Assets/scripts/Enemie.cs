using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
       player= GameObject.FindWithTag("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(new Vector3(transform.localRotation.x,
            transform.localRotation.y,
            axeDeTire()));
        if (CircleCollider2D)
    }

    public float axeDeTire()
    {

        Vector2 positionJoueur =player.transform.position;
        Vector2 positionEnemie = transform.position;
        Vector2 trajetBale = positionJoueur - positionEnemie;
        trajetBale.Normalize();
        float rotationEnemie = Mathf.Atan2(trajetBale.y, trajetBale.x) * Mathf.Rad2Deg - 90.0f;

        Debug.Log(rotationEnemie);

        return rotationEnemie;
    }
        

}
