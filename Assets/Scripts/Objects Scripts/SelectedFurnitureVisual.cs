using UnityEngine;

public class SelectedFurnitureVisual : MonoBehaviour
{
    [SerializeField] private InteractableAsset interactableAsset;
    [SerializeField] private GameObject[] visualGameObjectArray;

    private void Start()
    {
        Player.Instance.OnSelectedAssetChanged += Instance_OnSelectedFurnitureChanged;
    }

    private void Instance_OnSelectedFurnitureChanged(object sender, Player.OnSelectedAssetChangedEventArgs e)
    {
        if(e.selectedCounter == interactableAsset)
        {
            Show();
        }
        else
        {
            Hide();
        }

    }

    private void Show()
    {
        foreach(GameObject visualGameObject in visualGameObjectArray)
        {
            visualGameObject.SetActive(true);
        }
    }

    private void Hide()
    {
        foreach(GameObject visualGameObject in visualGameObjectArray)
        {
            visualGameObject.SetActive(false);
        }
    }
}
