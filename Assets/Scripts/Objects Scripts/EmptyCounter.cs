using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;

public class EmptyCounter : MonoBehaviour
{

    [SerializeField] private SceneObjectSO sceneObjectSO;
    [SerializeField] private Transform counterTopReference;
    private SceneObject sceneObject;

    public void Interact()
    {
        //Debug.Log(SceneObjecetTransform.GetComponent<SceneObject>().GetSceneObjectSO().objectName);

        if(sceneObject == null)
        {
            Debug.Log("Empty Counter Interaction");
            Transform SceneObjecetTransform = Instantiate(sceneObjectSO.prefab, counterTopReference);
            SceneObjecetTransform.localPosition = Vector3.zero;

            sceneObject = SceneObjecetTransform.GetComponent<SceneObject>();
            
        }
        //Debug.Log(SceneObjecetTransform.GetComponent<SceneObject>().GetSceneObjectSO().objectName);

    }
}
