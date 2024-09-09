using System;
using UnityEngine;
using TMPro;
public class basket : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public LayerMask mask;
    public int pts;
    public TMP_Text score;
    void Start()
    {
        pts = 0;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Collider2D[] arr = Physics2D.OverlapBoxAll(transform.position, new Vector2(3.5f, 2f),0,layerMask:mask, -10, 10);
        print(arr.Length);
        if (arr.Length != 0 )
        {
            foreach (Collider2D collider in arr)
            {
                pts++;
                score.text = "Score: " + pts;
                Destroy(collider.gameObject);
            }
        }
    }
}
