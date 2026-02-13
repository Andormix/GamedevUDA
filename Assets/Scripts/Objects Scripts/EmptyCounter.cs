using UnityEngine;

public class EmptyCounter : MonoBehaviour
{

    [SerializeField] private SceneObject ScenceObject;
    [SerializeField] private Transform counterTopReference;

    public void Interact()
    {
        Debug.Log("Empty Counter Interaction");
        Transform SceneObjecetTransform = Instantiate(ScenceObject.prefab, counterTopReference);
        SceneObjecetTransform.localPosition = Vector3.zero;

    }
}
