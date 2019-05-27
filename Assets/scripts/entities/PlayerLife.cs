using UnityEngine;
using System.Collections;

public class PlayerLife : Life
{
    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider2D = collision.collider;
        if (collider2D.CompareTag("enemy-bullet"))
        {
            Bullet bullet = collider2D.GetComponent<Bullet>();

            Health -= bullet.Damage;
            _healthBar.setPercentage(Health);
            if (Health <= 0f)
            {
                Die();
            }
        }
    }
}
