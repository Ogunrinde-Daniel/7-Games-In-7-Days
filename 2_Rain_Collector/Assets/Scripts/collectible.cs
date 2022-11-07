using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    string type = "unknown";
    int speed = Random.Range(20,50);
    public Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.position = randomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector2 randomPosition()
    {
        float[] targetSize = {0,0 };
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        float minX = bounds.x + targetSize[0] / 2f;
        float maxX = minX + targetSize[0];
        float minY = bounds.y + targetSize[1] / 2f;
        float maxY = minY + targetSize[1];

        return new Vector2(Random.Range(minX,maxX), Random.Range(minY, maxY));
    }
}
