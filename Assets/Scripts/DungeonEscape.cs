using UnityEngine;
using UnityEngine.UI;

public class DungeonEscape : MonoBehaviour
{
    #region VARIABLES

    #region SERIALIZABLE
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    #endregion

    State[] nextStates;
    State state;
    #endregion

    #region MONOBEHAVIOUR CALLBACK METHODS
    private void Start()
    {
        state = startingState;
        textComponent.text = state.StateStory;
    }

    private void Update()
    {
        ChangeState();
    }
    #endregion

    #region CLASS METHODS
    public void ChangeState()
    {
        var nextStates = state.NextStates;

        for (int i = 0; i < nextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextStates[i];
            }
        }

        textComponent.text = state.StateStory;
    }
    #endregion
}
