using System;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerInputActions;
    public event EventHandler OnInteractAction;

    private void Awake()
    {
        playerInputActions  = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        //Debug.Log("E pressed.");
        if(OnInteractAction != null)
        {
           OnInteractAction(this, EventArgs.Empty); 
        }
    }

    public Vector2 GetMovementVectorNorm()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        //Debug.Log(inputVector);
        return inputVector;
    }

}
