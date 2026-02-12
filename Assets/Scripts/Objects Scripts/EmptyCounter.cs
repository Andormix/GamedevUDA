using UnityEngine;

public class EmptyCounter : MonoBehaviour
{

    [SerializeField] private Transform potPrefab;
    [SerializeField] private Transform counterTopReference;

    public void Interact()
    {
        Debug.Log("Empty Counter Interaction");
        Transform potTransform = Instantiate(potPrefab, counterTopReference);
        potTransform.localPosition = Vector3.zero;

    }
}
