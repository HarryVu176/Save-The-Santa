using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float Speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(1);
    }

    // Update is called once per frame
    void Update()
    {
        // Save current position of object
        Vector3 currentPosition = transform.position;

        // Debug.Log(Time.deltaTime);

        // Modify position of object
        currentPosition.x -= Speed * Time.deltaTime;

        if (currentPosition.x <= -21.16)
        {
            currentPosition.x += 42.32f;
            // random y position
        }

        // Apply the changed position
        transform.position = currentPosition;
    }
}
