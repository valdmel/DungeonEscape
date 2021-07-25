using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    #region VARIABLES
    #region SERIALIZABLE
    [SerializeField, TextArea(10, 14)] private string storyText;
    [SerializeField] State[] nextStates;
    #endregion

    public string StateStory => storyText;
    public State[] NextStates => nextStates;
    #endregion

}
