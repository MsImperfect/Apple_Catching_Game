using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Basket : MonoBehaviour
{
    public Rigidbody2D basket;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.score = 0;
        basket = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float move = Input.GetAxisRaw("Horizontal");
        basket.velocity = Vector3.right * move * moveSpeed * Time.fixedDeltaTime;
    }

}
