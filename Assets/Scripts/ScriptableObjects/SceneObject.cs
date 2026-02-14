using UnityEngine;

public class SceneObject : MonoBehaviour
{
    [SerializeField] private SceneObjectSO sceneObjectSO;

    private InterfaceSceneObjectParent sceneObjectParent;

    public SceneObjectSO GetSceneObjectSO()
    {
        return sceneObjectSO;
    }

    public void SetSceneObjectParent(InterfaceSceneObjectParent sceneObjectParent)
    {
        if(this.sceneObjectParent != null)
        {
            this.sceneObjectParent.ClearSceneObject();
        }

        this.sceneObjectParent = sceneObjectParent;

        //Make sure it is empty
        if (sceneObjectParent.HasSceneObject())
        {
            Debug.Log("Error 01: InterfaceSceneObjectParent already have an object.");
        }
        sceneObjectParent.SetSceneObject(this);

        //Update el visual
        transform.parent = sceneObjectParent.GetSceneObjectSpawnReference();
        transform.localPosition = Vector3.zero;
    }

    public InterfaceSceneObjectParent GetSceneObjectParent()
    {
        return sceneObjectParent;
    }

    public void DeleteObject()
    {
        sceneObjectParent.ClearSceneObject();
        Destroy(gameObject);
    }

    //Spawns an object and set it to parent.
    public static SceneObject SpawnSceneObject(SceneObjectSO sceneObjectSO, InterfaceSceneObjectParent sceneObjectParent)
    {
        Transform SceneObjecetTransform = Instantiate(sceneObjectSO.prefab);
        SceneObject sceneObject = SceneObjecetTransform.GetComponent<SceneObject>();
        sceneObject.SetSceneObjectParent(sceneObjectParent); 
        return sceneObject;
        
    }
}
