using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{    
    public float maxHealth = 100;
    public float minHealth = 0;    

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        _health = maxHealth;
        healthBar.setPercentage(Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Die()
    {
        Debug.Log("die");
        Destroy(this.gameObject);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider2D = collision.collider;
        if (collider2D.CompareTag("bullet"))
        {
            Bullet bullet = collider2D.GetComponent<Bullet>();
                                      
            Health -= bullet.Damage;
            healthBar.setPercentage(Health);
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


    [SerializeField]
    private float _health = 100f;
}
