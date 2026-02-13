using UnityEngine;

public class SceneObject : MonoBehaviour
{
    [SerializeField] private SceneObjectSO sceneObjectSO;

    private EmptyCounter emptyCounter;

    public SceneObjectSO GetSceneObjectSO()
    {
        return sceneObjectSO;
    }

    public void SetEmptyCounter(EmptyCounter emptyCounter)
    {
        this.emptyCounter = emptyCounter;
    }

    public EmptyCounter GetEmptyCounter()
    {
        return emptyCounter;
    }
}
