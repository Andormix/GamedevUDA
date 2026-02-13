using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;

public class EmptyCounter : MonoBehaviour, InterfaceSceneObjectParent
{

    [SerializeField] private SceneObjectSO sceneObjectSO; // What kind of Object will spawn.
    [SerializeField] private Transform sceneObjectSpawnPointReference; // Position the Object will be placed when spawn.
    private SceneObject sceneObject; // Current Scene Object.

    // Function that defines the logic when player interacts with the Counter.
    public void Interact(Player player)
    {
        //If no Object on Top: Create an object Instance of Type sceneObjectSO.
        if(sceneObject == null)
        {
            Transform SceneObjecetTransform = Instantiate(sceneObjectSO.prefab, sceneObjectSpawnPointReference);
            SceneObjecetTransform.GetComponent<SceneObject>().SetSceneObjectParent(this);

            Debug.Log("Empty Counter Interaction - Spawning Object");
        }
        else // If Object on Top: Give Object to player
        {
            sceneObject.SetSceneObjectParent(player);
            Debug.Log("Full Counter Interaction - Giving Object to Player ");

        }
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
