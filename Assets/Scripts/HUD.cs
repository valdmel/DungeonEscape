using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    #region VARIABLES
    #region SERIALIZABLE
    [Header("Dialogue Properties")]
    [SerializeField] private Text dialogueHUD;
    #endregion
    #endregion

    #region MONOBEHAVIOUR CALLBACK METHODS
    private void OnEnable() => GameManager.OnDialogueChange += DisplayDialogueLine;

    private void OnDisable() => GameManager.OnDialogueChange += DisplayDialogueLine;
    #endregion

    #region CLASS METHODS
    private void DisplayDialogueLine(string dialogueLine) => dialogueHUD.text = dialogueLine;
    #endregion
}
