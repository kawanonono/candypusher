using UnityEngine;
using UnityEngine.InputSystem;

public class DeviceInput : MonoBehaviour
{
    private InputAction createCandyAction;
    private InputAction inputVector2Action;
    public createcandy createCandy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        createCandyAction = InputSystem.actions.FindAction("CreateCandy");
        inputVector2Action = InputSystem.actions.FindAction("ValueTest");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(inputVector2Action.ReadValue<Vector2>());
        if (createCandyAction.WasPressedThisFrame())
        {
            createCandy.AddCandy();
        
        }
    }
}
