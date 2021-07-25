using UnityEngine;
using UnityEngine.UI;

public class DungeonEscape : MonoBehaviour
{
    #region VARIABLES
    #region SERIALIZABLE
    [SerializeField] private Text dialogueText;
    [SerializeField] private DialogueLine startingState;
    #endregion

    private DialogueLine[] nextStates;
    private DialogueLine state;
    #endregion

    #region MONOBEHAVIOUR CALLBACK METHODS
    private void Start()
    {
        state = startingState;
        dialogueText.text = state.Dialogue;
    }

    private void Update() => ChangeState();
    #endregion

    #region CLASS METHODS
    public void ChangeState()
    {
        nextStates = state.NextDialogueLine;

        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }

        dialogueText.text = state.Dialogue;
    }
    #endregion
}
