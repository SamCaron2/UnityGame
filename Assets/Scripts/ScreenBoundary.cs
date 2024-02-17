using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerBounds : MonoBehaviour
{
    private Camera mainCamera;
    private float objectWidth;
    private float objectHeight;

    void Start()
    {
        mainCamera = Camera.main; // Automatically find the main camera
        objectWidth = GetComponent<SpriteRenderer>().bounds.extents.x;
        objectHeight = GetComponent<SpriteRenderer>().bounds.extents.y;
    }

    void LateUpdate()
    {
        Vector3 viewPos = mainCamera.WorldToViewportPoint(transform.position);

        // Clamp the viewport position to keep the entire object within the screen
        viewPos.x = Mathf.Clamp(viewPos.x, 0 + objectWidth, 1 - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, 0 + objectHeight, 1 - objectHeight);

        transform.position = mainCamera.ViewportToWorldPoint(viewPos);
    }
}






