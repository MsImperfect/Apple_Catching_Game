using UnityEngine;
using static UnityEngine.UI.Image;
using UnityEngine.UIElements;

public class apples : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject apple;
    public GameObject boundary1;
    public GameObject boundary2;
    public float spawn_rate;
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= spawn_rate)
        {
            timer = 0;
            Instantiate(apple, new Vector2(Random.Range(boundary1.transform.position.x, boundary2.transform.position.x), boundary1.transform.position.y), Quaternion.identity);
        }
        timer += Time.deltaTime;
    }
}
