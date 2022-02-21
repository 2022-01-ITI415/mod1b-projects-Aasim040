using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Movement : MonoBehaviour
{
    [Header("Set in Inspector")]

    public GameObject applePrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections = 0.1f;

    public float secondsBetweenAppleDrops = 1f;

    void Start()
    {
        Invoke("DropApple", 2f);

    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.z += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.z < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.z > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }

    }

    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
