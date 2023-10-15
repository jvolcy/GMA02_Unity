using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.x += speed;
        transform.position = pos;

        if (pos.x > 640)
        {
            Destroy(gameObject);
        }
    }
}