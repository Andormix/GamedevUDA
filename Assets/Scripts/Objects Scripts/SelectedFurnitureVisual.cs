using UnityEngine;

public class SelectedFurnitureVisual : MonoBehaviour
{
    [SerializeField] private EmptyCounter emptyCounter;

    private void Start()
    {
        Player.Instance.OnSelectedFurnitureChanged += Instance_OnSelectedFurnitureChanged;
    }

    private void Instance_OnSelectedFurnitureChanged(object sender, Player.OnSelectedFurnitureChangedEventArgs e)
    {
        //e.selectedCounter
    }
}
