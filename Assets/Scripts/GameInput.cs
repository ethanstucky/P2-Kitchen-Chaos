using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class GameInput : MonoBehaviour
{
    public event EventHandler OnInteractAction;
    public event EventHandler OnInteractAlternateAction;
    
    private PlayerInputActions playerInputActions;
    
    
    private void Awake()
    { 
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();

        playerInputActions.Player.Interact.performed += Interact_performed;
        playerInputActions.Player.InteractAlternate.performed += InteractAlternate_performed;
    }

    private void InteractAlternate_performed(InputAction.CallbackContext obj)
    {
       OnInteractAlternateAction?.Invoke(this, EventArgs.Empty);
    }

    private void Interact_performed(InputAction.CallbackContext obj)
    {
       OnInteractAction?.Invoke(this, EventArgs.Empty);
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        
        inputVector.Normalize();
        
        return inputVector;
    } 
}
