using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            GameManager.Instance.score++;
            Destroy(gameObject);
        }
    }
}
