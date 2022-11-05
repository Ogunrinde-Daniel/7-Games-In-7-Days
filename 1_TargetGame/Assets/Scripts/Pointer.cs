using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public Rigidbody2D pointer;

    void Start()
    {
        pointer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        pointer.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

 
   
}
