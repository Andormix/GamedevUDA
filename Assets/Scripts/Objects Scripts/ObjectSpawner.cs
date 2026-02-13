using UnityEngine;

public class ObjectSpawner: InteractableAsset
{
    // --------------------  VAR --------------------
    [SerializeField] private SceneObjectSO sceneObjectSO; // What kind of Object will spawn.

    // --------------------  Unity Functions -------------------- 

    // -------------------- Custom Functions -------------------- 

    // Function that defines the logic when player interacts with the Counter.
    public override void Interact(Player player)
    {
        //If no Object on Top: Create an object Instance of Type sceneObjectSO.
        if(!HasSceneObject())
        {
            Transform SceneObjecetTransform = Instantiate(sceneObjectSO.prefab, GetSceneObjectSpawnReference());
            SceneObjecetTransform.GetComponent<SceneObject>().SetSceneObjectParent(player);

            Debug.Log("Empty Counter Interaction - Spawning Object");
        }
    }
}
