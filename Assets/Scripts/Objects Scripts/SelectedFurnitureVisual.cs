using UnityEngine;

public class SelectedFurnitureVisual : MonoBehaviour
{
    [SerializeField] private EmptyCounter emptyCounter;
    [SerializeField] private GameObject visualGameObject;

    private void Start()
    {
        Player.Instance.OnSelectedFurnitureChanged += Instance_OnSelectedFurnitureChanged;
    }

    private void Instance_OnSelectedFurnitureChanged(object sender, Player.OnSelectedFurnitureChangedEventArgs e)
    {
        if(e.selectedCounter == emptyCounter)
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
        visualGameObject.SetActive(true);
    }

    private void Hide()
    {
        visualGameObject.SetActive(false);
    }
}
