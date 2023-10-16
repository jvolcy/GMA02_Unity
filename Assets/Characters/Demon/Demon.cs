using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demon : MonoBehaviour
{
    GameManager gameManager;

    [SerializeField]
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //find the game manager
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x -= speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -320f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Dragon"))
        {
            gameManager.DemonHitDragon();

            //disable the collider
            GetComponent<CapsuleCollider2D>().enabled = false;

            //disable the sprite renderer
            GetComponent<SpriteRenderer>().enabled = false;
            //Destroy(gameObject);
        }

        if (collision.CompareTag("Fireball"))
        {
            gameManager.DemonHitFireball();

            //disable the collider
            GetComponent<CapsuleCollider2D>().enabled = false;

            //disable the sprite renderer
            GetComponent<SpriteRenderer>().enabled = false;

            GetComponent<AudioSource>().Play();
            //Destroy(gameObject);
        }

    }
}
