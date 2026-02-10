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
        //Separación de lógicas
        Vector2 inputVector = gameInput.GetMovementVectorNorm();

        Vector3 movementDirection;
        movementDirection = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += movementDirection * movementsSpeed * Time.deltaTime;  //Time.deltatime para que la velociadad sea independiente del framerate.

        //Euler o Quaternion mes complicats. Slerp interpola entre 2 puntos (Transiciones sin Mixamo)
        transform.forward = Vector3.Slerp(transform.forward, movementDirection, movementsSpeed * Time.deltaTime);
        isWalking = movementDirection != Vector3.zero;
    }

    public bool IsWalking()
    {
        return isWalking;
    }
}
