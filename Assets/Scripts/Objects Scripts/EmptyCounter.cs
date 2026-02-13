using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;

public class EmptyCounter : MonoBehaviour, InterfaceSceneObjectParent
{

    [SerializeField] private SceneObjectSO sceneObjectSO;
    [SerializeField] private Transform sceneObjectSpawnPointReference;
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
                sceneObject.SetSceneObjectParent(secondCounter);
            }
        }
    }

    public void Interact(Player player)
    {
        //Debug.Log(SceneObjecetTransform.GetComponent<SceneObject>().GetSceneObjectSO().objectName);

        if(sceneObject == null)
        {
            Transform SceneObjecetTransform = Instantiate(sceneObjectSO.prefab, sceneObjectSpawnPointReference);
            SceneObjecetTransform.GetComponent<SceneObject>().SetSceneObjectParent(this);

            Debug.Log("Empty Counter Interaction - Spawning Object");
            //Debug.Log(sceneObject.GetEmptyCounter());
        }
        else // Give Object to player
        {
            sceneObject.SetSceneObjectParent(player);
            Debug.Log("Full Counter Interaction - Giving Object to Player ");
            //Debug.Log(sceneObject.GetEmptyCounter());
        }
        //Debug.Log(SceneObjecetTransform.GetComponent<SceneObject>().GetSceneObjectSO().objectName);

    }

    public Transform GetSceneObjectTopTransform()
    {
        return sceneObjectSpawnPointReference;
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
