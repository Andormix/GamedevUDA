using UnityEngine;

public class SceneObject : MonoBehaviour
{
    [SerializeField] private SceneObjectSO sceneObjectSO;

    public SceneObjectSO GetSceneObjectSO()
    {
        return sceneObjectSO;
    }
}
