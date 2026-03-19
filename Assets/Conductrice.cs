using UnityEngine;
using UnityEngine.InputSystem;

public class Conductrice : MonoBehaviour
{
    [SerializeField] float MoveSpeed = 0.05f;
    [SerializeField] float SteeringSpeed = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steer = 0;
        float move = 0;
        if (Keyboard.current.wKey.isPressed)
        {
            move = 1;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            steer = 1;
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            steer = -1;
        }
        transform.Translate(0, move * MoveSpeed * Time.deltaTime, 0);
        transform.Rotate(0, 0, steer * SteeringSpeed * Time.deltaTime);
        
    }
}
