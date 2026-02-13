using UnityEngine;

public interface InterfaceSceneObjectParent
{
    public Transform GetSceneObjectTopTransform();
    public void SetSceneObject(SceneObject sceneObject);
    public SceneObject GetSceneObject();
    public void ClearSceneObject();
    public bool HasSceneObject();

}
    

