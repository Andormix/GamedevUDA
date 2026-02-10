using System;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    //VARS
    [SerializeField] private float movementsSpeed = 5f; //Variables publicas permiten editar desde el editor de Unity pero cualquier clase puede acceder.
    [SerializeField] private GameInput gameInput;
    private bool isWalking;

    // Update is called once per frame
    private void Update()
    {
        Movement();
        Interactions();
    }

    public bool IsWalking()
    {
        return isWalking;
    }

    private void Movement()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNorm();
        Vector3 movementDirection = new Vector3(inputVector.x, 0f, inputVector.y);
        float playerRadius = 0.5f;
        float playerHeight = 2f;
        float movementDistance = movementsSpeed * Time.deltaTime;
        bool canPlayerMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, movementDirection, movementDistance);

        if (!canPlayerMove)
        {
            //Try to move in X direction
            Vector3 movementDirectionX = new Vector3(movementDirection.x,0,0);
            canPlayerMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, movementDirectionX, movementDistance); 
            if(canPlayerMove)
            {
                // Allowed to move on X axis
                movementDirection = movementDirectionX;
            }
            else
            {
                //Try to move in Z direction
                Vector3 movementDirectionZ = new Vector3(0,0,movementDirection.z);
                canPlayerMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, movementDirectionZ, movementDistance);

                // Allowed to move on Z axis
                if(canPlayerMove)
                {
                    movementDirection = movementDirectionZ;
                }
            }
            //Else = Cannot move in any dir
        }

        if (canPlayerMove)
        {
            transform.position += movementDirection * movementDistance;  //Time.deltatime para que la velociadad sea independiente del framerate.
        }

        //Euler o Quaternion mes complicats. Slerp interpola entre 2 puntos (Transiciones sin Mixamo)
        transform.forward = Vector3.Slerp(transform.forward, movementDirection, movementsSpeed * Time.deltaTime);
        isWalking = movementDirection != Vector3.zero;
    }

    private void Interactions()
    {

        Vector2 inputVector = gameInput.GetMovementVectorNorm();
        Vector3 movementDirection = new Vector3(inputVector.x, 0f, inputVector.y);
        float InteractionDistance = 2f;

        Physics.Raycast(transform.position, movementDirection, out RaycastHit raycastHit, InteractionDistance);
    }
}
