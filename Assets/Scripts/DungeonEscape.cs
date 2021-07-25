using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class DungeonEscape : MonoBehaviour
{
    #region VARIABLES
    #region SERIALIZABLE
    [SerializeField] private Text dialogueText;
    [SerializeField] private DialogueLine startingDialogueLine;
    #endregion

    private DialogueLine currentDialogueLine;
    #endregion

    #region MONOBEHAVIOUR CALLBACK METHODS
    private void Start()
    {
        currentDialogueLine = startingDialogueLine;
        dialogueText.text = currentDialogueLine.Dialogue;
    }
    #endregion

    #region CLASS METHODS
    public void OnMoveNorth(InputAction.CallbackContext inputContext)
    {
        if (inputContext.performed)
        {
            currentDialogueLine = currentDialogueLine.MoveNorthDialogue;
            DisplayDialogueLine();
        }
    }

    public void OnMoveLeft(InputAction.CallbackContext inputContext)
    {
        if (inputContext.performed)
        {
            currentDialogueLine = currentDialogueLine.MoveLeftDialogue;
            DisplayDialogueLine();
        }
    }

    public void OnMoveSouth(InputAction.CallbackContext inputContext)
    {
        if (inputContext.performed)
        {
            currentDialogueLine = currentDialogueLine.MoveSouthDialogue;
            DisplayDialogueLine();
        }
    }

    public void OnMoveRight(InputAction.CallbackContext inputContext)
    {
        if (inputContext.performed)
        {
            currentDialogueLine = currentDialogueLine.MoveRightDialogue;
            DisplayDialogueLine();
        }
    }

    public void DisplayDialogueLine() => dialogueText.text = currentDialogueLine.Dialogue;
    #endregion
}
