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
        transform.parent = sceneObjectParent.GetSceneObjectTopTransform();
        transform.localPosition = Vector3.zero;
    }

    public InterfaceSceneObjectParent GetSceneObjectParent()
    {
        return sceneObjectParent;
    }
}
