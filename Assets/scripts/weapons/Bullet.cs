using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, _lifeSpan);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         
    }
    public float Damage => _damage;


    [SerializeField]
    private float _damage = 1f;

    [SerializeField]
    private float _speed = 25.0f;

    [SerializeField]
    private float _lifeSpan = 5;
}
