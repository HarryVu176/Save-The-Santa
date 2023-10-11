using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f; // gravity set default as -9.8
    public float strength = 5f; // strength set default as 5
    private Vector3 startingPos;
    public Player player;
    public AudioSource flySound;
    public AudioSource collideSound;

    private void Start()
    {
        startingPos = transform.position;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) 
        {
            direction = Vector3.up * strength;
            flySound.Play();
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger");
        if (other.gameObject.tag == "Obstacle")
        {
            collideSound.Play();
            player.Reset();
            FindObjectOfType<GameManager>().GameOver(); 
        } else if (other.gameObject.tag == "Scoring")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
        }

    }

    public void Reset()
    {
        transform.position = startingPos;
    }
    
}
