using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{

    string type = "unknown";
    int speed = Random.Range(20,50);
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void randomPosition()
    {
        float[] targetSize = {0,0 };
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        float minX = -bounds.x + targetSize[0] / 2f;
        float maxX =  bounds.x - targetSize[0] / 2f;
        float minY = -bounds.y + targetSize[1] / 2f;
        float maxY =  bounds.y - targetSize[1] / 2f;
    }
}
