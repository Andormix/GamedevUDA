using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;

public class EmptyCounter : MonoBehaviour
{

    [SerializeField] private SceneObjectSO sceneObjectSO;
    [SerializeField] private Transform counterTopReference;
    private SceneObject sceneObject;

    //DELETE
    [SerializeField] private EmptyCounter secondCounter;
    [SerializeField] private bool testing;
    private void Update()
    {
        if(testing && Input.GetKeyDown(KeyCode.T))
        {
            if(sceneObject != null)
            {
                sceneObject.SetEmptyCounter(secondCounter);
            }
        }
    }

    public void Interact()
    {
        //Debug.Log(SceneObjecetTransform.GetComponent<SceneObject>().GetSceneObjectSO().objectName);

        if(sceneObject == null)
        {
            Transform SceneObjecetTransform = Instantiate(sceneObjectSO.prefab, counterTopReference);
            SceneObjecetTransform.GetComponent<SceneObject>().SetEmptyCounter(this);

            Debug.Log("Empty Counter Interaction - Spawning Object at:");
            Debug.Log(sceneObject.GetEmptyCounter());
        }
        else
        {
            Debug.Log("Full Counter Interaction at: ");
            Debug.Log(sceneObject.GetEmptyCounter());
        }
        //Debug.Log(SceneObjecetTransform.GetComponent<SceneObject>().GetSceneObjectSO().objectName);

    }

    public Transform GetSceneObjectTopTransform()
    {
        return counterTopReference;
    }

    public void SetSceneObject(SceneObject sceneObject)
    {
        this.sceneObject = sceneObject;
    }

    public SceneObject GetSceneObject()
    {
        return this.sceneObject;
    }

    public void ClearSceneObject()
    {
        this.sceneObject = null;
    }

    public bool HasSceneObject()
    {
        return sceneObject != null;
    }
}
