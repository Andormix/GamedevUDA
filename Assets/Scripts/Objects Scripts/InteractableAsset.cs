using UnityEngine;

public class InteractableAsset : MonoBehaviour
{
    //TODO: MAKE ABSTRACT CLASS INSTEAD
    public virtual void Interact(Player player)
    {
        Debug.LogError("InteractableAsset.Interact should not be triggerd");
    }
}
