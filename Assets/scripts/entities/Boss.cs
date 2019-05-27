using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public event Action Died;
    private Life _life;


    private void Awake()
    {
        _life = GetComponent<Life>();
    }

    private void OnEnable()
    {
        _life.Died += OnLifeDied;
    }

    private void OnDisable()
    {
        _life.Died -= OnLifeDied;
    }

    private void OnLifeDied()
    {
        Died?.Invoke();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
