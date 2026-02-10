using UnityEngine;

public class Player : MonoBehaviour
{
    //VARS
    [SerializeField] private float movementsSpeed = 5f; //Variables publicas permiten editar desde el editor de Unity pero cualquier clase puede acceder.
    private bool isWalking;

    // Update is called once per frame
    private void Update()
    {
        //Lógica del input y movimiento separadas.
        Vector2 inputVector = new Vector2(0,0);
        Vector3 movementDirection;

        if(Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if(Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if(Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if(Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
        }

        // Normalizamos para que el movimiento en diagonal x+y sea igual a 1 y no superior.
        inputVector = inputVector.normalized;
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
