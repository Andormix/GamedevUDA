using UnityEngine;

public class InteractableAsset : MonoBehaviour, InterfaceSceneObjectParent
{
    // --------------------  VAR --------------------
    [SerializeField] private Transform sceneObjectSpawnPointReference; // Position the Object will be placed when spawn.
    private SceneObject sceneObject; // Current Scene Object. (We could meke it protected instead)

    //TODO: MAKE ABSTRACT CLASS INSTEAD
    public virtual void Interact(Player player)
    {
        Debug.LogError("InteractableAsset.Interact should not be triggerd");
    }

    // ---------------- Interface Functions ----------------
    public Transform GetSceneObjectSpawnReference()
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
