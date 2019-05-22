using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : Weapon
{

    public float fireDistance = 2.0f;
    public GameObject Bullet;
    public float speed = 20.0f;
    public override void Fire(Vector2 direction)
    {
        direction.Normalize();
        var recuperationPSourisDegee = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;

        Instantiate(Bullet, transform.position + new Vector3(direction.x, direction.y, 0.0f) * fireDistance, Quaternion.Euler(0.0f, 0.0f, recuperationPSourisDegee));
        Debug.Log(direction);

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool myFire = Input.GetButtonDown("Fire1");
        if (myFire == true)
        {
            Vector2 positionSouris = recuperationPSouris();
            Vector2 positionActuelle = (Vector2)transform.position;


            Fire(positionSouris - positionActuelle);
        }

    }

    public Vector2 recuperationPSouris()
    {
        //var cam = ;       
        Vector3 mousePos = Input.mousePosition;
        //mousePos.x = currentEvent.mousePosition.x;
        //mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        Vector3 point = Camera.main.ScreenToWorldPoint(mousePos);
        var positionMouse2D = (Vector2)point;

        return positionMouse2D;
    }


}
