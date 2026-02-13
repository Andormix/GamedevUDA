using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;

public class EmptyCounter : InteractableAsset
{

    [SerializeField] private SceneObjectSO sceneObjectSO; // What kind of Object will spawn.

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
}
