using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]

public class Plane : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _template;
    [SerializeField] private float _cooldown = 2f;
    [SerializeField] private float time = 0;

    private void Start()
    {
        SpawnElements();
    }

    private void SpawnElements()
    {
       Instantiate(_template, transform.position, Quaternion.identity);
        
    }
    private void Update()
    {
        transform.position += Vector3.forward * _speed;
        time += Time.deltaTime;
        if (time >= _cooldown)
        {
            SpawnElements();
            time = 0;
        }
    }
}