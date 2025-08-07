using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public float maxHeight = 13;
    public float minHeight = -11;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (transform.position.y > maxHeight || transform.position.y < minHeight)
        {
            deathOfBird();
        }
    }

    private void deathOfBird()
    {
        birdIsAlive = false;
        logic.gameOver();
    }

private void OnCollisionEnter2D(Collision2D collision)
    {
        deathOfBird();
    }
}
