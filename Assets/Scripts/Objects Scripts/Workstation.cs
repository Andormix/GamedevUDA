using UnityEngine;

public class Workstation : InteractableAsset
{

    [SerializeField] private SceneObjectTransformSO[] sceneObjectTransformArray;
    private int workProgress;

    // Function that defines the logic when player interacts with the Counter.
    public override void Interact(Player player)
    {
        if(!HasSceneObject())
        {
            if(player.HasSceneObject())
            {
                //Drop Object Here If Object can be worked.
                if(HasObjectTransform(player.GetSceneObject().GetSceneObjectSO()))
                {
                    player.GetSceneObject().SetSceneObjectParent(this);
                    workProgress = 0;
                }
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
        if(HasSceneObject() && HasObjectTransform(GetSceneObject().GetSceneObjectSO()))
        {
            workProgress++;
            SceneObjectTransformSO sceneObjectTransformSO = GetSceneObjectTransformSO(GetSceneObject().GetSceneObjectSO());
            if(workProgress >= sceneObjectTransformSO.workProgressMax)
            {
                SceneObjectSO outputSceneObjectSO = GetOutputForInput(GetSceneObject().GetSceneObjectSO());
                GetSceneObject().DeleteObject();

                SceneObject.SpawnSceneObject(outputSceneObjectSO, this);
                Debug.Log("Player/Workstation Interaction - Deleting Object and Creating New One");
            }
        }
    }

    private bool HasObjectTransform(SceneObjectSO inputSceneObjectSO)
    {
        SceneObjectTransformSO sceneObjectTransformSO = GetSceneObjectTransformSO(inputSceneObjectSO);
        return sceneObjectTransformSO != null;
    }

    private SceneObjectSO GetOutputForInput(SceneObjectSO inputSceneObjectSO)
    {

        SceneObjectTransformSO sceneObjectTransformSO = GetSceneObjectTransformSO(inputSceneObjectSO);
        if(sceneObjectTransformSO != null)
        {
            return sceneObjectTransformSO.output;
        }
        return null;
    }

    private SceneObjectTransformSO GetSceneObjectTransformSO(SceneObjectSO inputSceneObjectSO)
    {
        foreach(SceneObjectTransformSO sceneObjectTransformSO in sceneObjectTransformArray)
        {
            if(sceneObjectTransformSO.input == inputSceneObjectSO)
            {
                return sceneObjectTransformSO;
            }
        }
        return null;
        
    }
}
