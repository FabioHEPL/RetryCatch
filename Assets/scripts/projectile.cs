using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
  
    public float vitesseDeProjectile = 25.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * vitesseDeProjectile * Time.deltaTime);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {

    }
}
