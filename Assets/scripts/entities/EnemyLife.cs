using UnityEngine;
using System.Collections;

public class EnemyLife : Life
{
    public override void Die()
    {
        base.Die();
        Destroy(this.gameObject);
    }

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider2D = collision.collider;
        if (collider2D.CompareTag("player-bullet"))
        {
            Bullet bullet = collider2D.GetComponent<Bullet>();

            Health -= bullet.Damage;
           // _healthBar.setPercentage(Health);
            if (Health <= 0f)
            {
                Die();
            }
        }
    }
}
