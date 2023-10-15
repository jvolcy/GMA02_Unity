using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField]
    float topPosition = 165f;

    [SerializeField]
    float bottomPosition = -165f;

    [SerializeField]
    float speed = 0.5f;

    [SerializeField]
    GameObject FireballPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        pos.y += speed * Time.deltaTime * Input.GetAxis("Vertical");

        pos.y = Mathf.Clamp(pos.y, bottomPosition, topPosition);
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var fireBall = Instantiate(FireballPrefab);
            fireBall.transform.position = transform.position + new Vector3(80, 43, 0);
        }
    }
}
