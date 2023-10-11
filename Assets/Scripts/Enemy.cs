using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float Speed = 5.0f; // default value speed
    // Start is called before the first frame update
    private Vector3 startingPos;
    public Enemy ice1;
    public Enemy ice2;
    public Enemy ice3;
    public Enemy ice4;
    public Enemy ice5;
    public Enemy ice6;
    public Enemy ice7;

    void Start()
    {
        Random.InitState(1);
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Save current position of object
        Vector3 currentPosition = transform.position;

        // Debug.Log(Time.deltaTime);

        // Modify position of object
        currentPosition.x -= Speed * Time.deltaTime;

        if (currentPosition.x <= -12.0f)
        {
            currentPosition.x = 12.0f;
            // random y position
            currentPosition.y = Random.Range(-3.0f, 3.5f);
        }

        // Apply the changed position
        transform.position = currentPosition;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ice1.Reset();
        ice2.Reset();
        ice3.Reset();
        ice4.Reset();
        ice5.Reset();
    }

    public void Reset()
    {
        transform.position = startingPos;
    }
}
