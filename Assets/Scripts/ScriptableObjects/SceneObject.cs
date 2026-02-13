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
        if(this.emptyCounter != null)
        {
            this.emptyCounter.ClearSceneObject();
        }

        this.emptyCounter = emptyCounter;

        //Make sure it is empty
        if (emptyCounter.HasSceneObject())
        {
            Debug.Log("Error 01: Counter already have an object.");
        }
        emptyCounter.SetSceneObject(this);

        //Update el visual
        transform.parent = emptyCounter.GetSceneObjectTopTransform();
        transform.localPosition = Vector3.zero;
    }

    public EmptyCounter GetEmptyCounter()
    {
        return emptyCounter;
    }
}
