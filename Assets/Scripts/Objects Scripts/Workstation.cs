using UnityEngine;

public class Workstation : InteractableAsset
{

    [SerializeField] private SceneObjectSO processedSceneObjectSO;

    // Function that defines the logic when player interacts with the Counter.
    public override void Interact(Player player)
    {
        if(!HasSceneObject())
        {
            if(player.HasSceneObject())
            {
                //Drop Object Here
                player.GetSceneObject().SetSceneObjectParent(this);
            }
        }
        else
        {
            if(!player.HasSceneObject())
            {
                GetSceneObject().SetSceneObjectParent(player);
            }
        }
    }

    public override void InteractAct(Player player)
    {
        if(HasSceneObject())
        {
            GetSceneObject().DeleteObject();
            Debug.Log("Player/Workstation Interaction - Deleting Object and Creating New One");

            Transform SceneObjecetTransform = Instantiate(processedSceneObjectSO.prefab, GetSceneObjectSpawnReference());
            SceneObjecetTransform.GetComponent<SceneObject>().SetSceneObjectParent(this);

            Debug.Log("Player/Spawner Interaction - Spawning Object");
        }
    }
}
