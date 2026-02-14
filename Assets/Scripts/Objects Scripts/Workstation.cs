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
            SceneObject.SpawnSceneObject(processedSceneObjectSO, this);
            Debug.Log("Player/Workstation Interaction - Deleting Object and Creating New One");
        }
    }
}
