using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IAction
{
    void Execute();
}


public class Collect : MonoBehaviour, IAction
{
    // -------------------------------------------------------------------------------------
    // @ PUBLIC
    // -------------------------------------------------------------------------------------
    public void Execute()
    {
        Collider2D collider = Physics2D.OverlapCircle(
            new Vector2(transform.position.x, transform.position.y),
            _radius);

        Debug.Log(collider);
        Debug.Log(new Vector2(transform.position.x, transform.position.y));

        Collectable collectable = collider?.GetComponent<Collectable>();

        if (collectable != null)
        {
            _inventory.AddItem(collectable.gameObject);            
            collectable.gameObject.SetActive(false);
            collectable.enabled = false;
            collider.enabled = false;
        }
    }

    // -------------------------------------------------------------------------------------
    // @ PRIVATE
    // -------------------------------------------------------------------------------------
    private void Awake()
    {       
        //_inventory = GetComponent<Inventory>();
        if (_inventory == null)
        {
            Debug.Log("Cannot collect items if there is no inventory.");
            enabled = false;
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Execute();
        }
    }

    [SerializeField]
    private float _radius = 5f;
    [SerializeField]
    private Inventory _inventory;
}
