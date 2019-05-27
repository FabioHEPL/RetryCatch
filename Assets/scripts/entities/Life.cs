using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{    
    public float maxHealth = 100;
    public float minHealth = 0;

    protected HealthBar _healthBar;

    public event Action Died;

    protected void OnEnable()
    {
        
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        _healthBar = GetComponentInChildren<HealthBar>();
        _health = maxHealth;
        //_healthBar.setPercentage(Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Die()
    {
        Died?.Invoke();
        
    }


    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider2D = collision.collider;
        if (collider2D.CompareTag("bullet"))
        {
            Bullet bullet = collider2D.GetComponent<Bullet>();
                                      
            Health -= bullet.Damage;
            
            if (Health <= 0f)
            {
                Die();
            }               
        }
    }    

    public float Health
    {
        get { return _health; }
        set
        {
            if (value > maxHealth)
                _health = maxHealth;
            else if (value < minHealth)
                _health = minHealth;
            else
                _health = value;
        }
    }

    [Header("Debug")]
    [SerializeField]
    protected float _health = 100f;
}
