using UnityEngine;
using System.Collections;
public class appleobject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(die());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator die() 
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
