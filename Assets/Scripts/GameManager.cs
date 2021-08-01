using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region VARIABLES
    public static Action<string> OnDialogueChange;

    #region SERIALIZABLE
    [Header("Dialogue Properties")]
    [SerializeField] private DialogueLine startingDialogueLine;
    #endregion

    private readonly List<string> items = new List<string>();
    private DialogueLine currentDialogueLine;
    #endregion

    #region MONOBEHAVIOUR CALLBACK METHODS
    private void Start()
    {
        currentDialogueLine = startingDialogueLine;

        OnDialogueChange?.Invoke(currentDialogueLine.Dialogue);
    }
    #endregion

    #region CLASS METHODS
    public void OnMoveNorth(InputAction.CallbackContext inputContext)
    {
        if (inputContext.performed)
        {
            currentDialogueLine.OnMoveNorth?.Invoke();

            currentDialogueLine = currentDialogueLine.MoveNorthDialogue;

            OnDialogueChange?.Invoke(currentDialogueLine.Dialogue);
        }
    }

    public void OnMoveLeft(InputAction.CallbackContext inputContext)
    {
        if (inputContext.performed)
        {
            currentDialogueLine.OnMoveLeft?.Invoke();

            currentDialogueLine = currentDialogueLine.MoveLeftDialogue;

            OnDialogueChange?.Invoke(currentDialogueLine.Dialogue);
        }
    }

    public void OnMoveSouth(InputAction.CallbackContext inputContext)
    {
        if (inputContext.performed)
        {
            currentDialogueLine.OnMoveSouth?.Invoke();

            currentDialogueLine = currentDialogueLine.MoveSouthDialogue;

            OnDialogueChange?.Invoke(currentDialogueLine.Dialogue);
        }
    }

    public void OnMoveRight(InputAction.CallbackContext inputContext)
    {
        if (inputContext.performed)
        {
            currentDialogueLine.OnMoveRight?.Invoke();

            currentDialogueLine = currentDialogueLine.MoveRightDialogue;

            OnDialogueChange?.Invoke(currentDialogueLine.Dialogue);
        }
    }

    public void AddItemToInventory(string itemName) => items.Add(itemName);
    #endregion
}
