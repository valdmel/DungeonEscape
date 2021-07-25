using UnityEngine;

[CreateAssetMenu(menuName = "DialogueLine")]
public class DialogueLine : ScriptableObject
{
    #region VARIABLES
    #region SERIALIZABLE
    [SerializeField, TextArea(10, 14)] private string dialogue;
    [SerializeField] DialogueLine[] nextDialogueLine;
    #endregion

    public string Dialogue => dialogue;
    public DialogueLine[] NextDialogueLine => nextDialogueLine;
    #endregion

}
