using UnityEngine;

public class ObjectType : MonoBehaviour
{
    [SerializeField] private SceneObjectSO sceneObjectSO;

    public SceneObjectSO GetSceneObjectSO()
    {
        return sceneObjectSO;
    }
}
