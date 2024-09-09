using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;
public class movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float mov;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(mov*speed*Time.deltaTime,0,0);
    }
    public void move(InputAction.CallbackContext  ctx)
    {
        mov = ctx.ReadValue<float>();
    }
}
