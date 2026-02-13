using UnityEngine;

public class EmptyCounter : MonoBehaviour
{

    [SerializeField] private SceneObjectSO sceneObject;
    [SerializeField] private Transform counterTopReference;

    public void Interact()
    {
        Debug.Log("Empty Counter Interaction");
        Transform SceneObjecetTransform = Instantiate(sceneObject.prefab, counterTopReference);
        SceneObjecetTransform.localPosition = Vector3.zero;

        Debug.Log(SceneObjecetTransform.GetComponent<ObjectType>().GetSceneObjectSO().objectName);

    }
}
