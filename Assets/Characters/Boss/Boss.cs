using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField]
    float topPosition = 150f;

    [SerializeField]
    float bottomPosition = -150f;

    [SerializeField]
    float speed = 1f;

    [SerializeField]
    GameObject babyPrefab;

    [SerializeField]
    GameObject demonPrefab;

    [SerializeField]
    float minFutureTime = 0.1f;

    [SerializeField]
    float maxFutureTime = 1.0f;

    bool goingUp = true;
    float futureTime;

    // Start is called before the first frame update
    void Start()
    {
        SetFutureTime();
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;

        if (goingUp)
        {
            pos.y += speed * Time.deltaTime;
            if (pos.y > topPosition) goingUp = false;
        }
        else
        {
            pos.y -= speed * Time.deltaTime;
            if (pos.y < bottomPosition) goingUp = true;
        }

        transform.position = pos;

        if (Time.time > futureTime)
        {
            SetFutureTime();
            if (Random.Range(1, 11) < 7)
            {
                var obj = Instantiate(demonPrefab);
                obj.transform.position = transform.position;
            }
            else
            {
                var obj = Instantiate(babyPrefab);
                obj.transform.position = transform.position;
            }
        }
    }

    void SetFutureTime()
    {
        futureTime = Time.time + Random.Range(minFutureTime, maxFutureTime);
    }
}
