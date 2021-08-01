using UnityEngine;

[CreateAssetMenu(menuName = "Item Action")]
public class ItemAction : ScriptableObject
{
    #region CLASS METHODS
    public void AddItemToInventory(string itemName)
    {
        var gameManager = FindObjectOfType<GameManager>();

        gameManager.GetComponent<GameManager>().AddItemToInventory(itemName);
    }
    #endregion
}
