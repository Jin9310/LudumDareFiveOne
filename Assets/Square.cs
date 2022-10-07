using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public float y;
    public float x;
    public float angle;
    public float speed;
    public float radius;

    private void FixedUpdate()
    {
        y = Mathf.Sin(angle) * radius;

        transform.position = new Vector2(x, y);
        angle -= speed * Time.deltaTime;
    }
}
