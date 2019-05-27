using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject hp;
    [SerializeField]
    private SpriteRenderer _hpRenderer;
    public Color Color
    {
        get
        {
            return _hpRenderer.color;
        }
        set
        {
            _hpRenderer.color = value;
        }
    }

    private void Awake()
    {
        _hpRenderer = hp.GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getPercentage()
    {
        return _percentage;
    }


    public void setPercentage(float value)
    {
        if (value < 0f)
            _percentage = 0;
        else if (value > 100f)
            _percentage = 100f;
        else
            _percentage = value;

        UpdateHP(value);
    }

    private void UpdateHP(float percentage)
    {
        hp.transform.localScale = new Vector3((baseScale / 100) * percentage, 1, 1);
    }

    private float baseScale = 1f;

    [SerializeField]
    private float _percentage = 100f;
}
