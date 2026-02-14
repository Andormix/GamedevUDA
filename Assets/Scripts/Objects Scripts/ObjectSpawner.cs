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
        if(!player.HasSceneObject())
        {

            SceneObject.SpawnSceneObject(sceneObjectSO, player);
            Debug.Log("Player/Spawner Interaction - Spawning Object");
        }
    }
}
