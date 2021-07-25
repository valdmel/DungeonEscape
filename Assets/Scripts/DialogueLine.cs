using UnityEngine;

[CreateAssetMenu(menuName = "DialogueLine")]
public class DialogueLine : ScriptableObject
{
    #region VARIABLES
    #region SERIALIZABLE
    [SerializeField, TextArea(10, 14)] private string dialogue;
    [SerializeField] DialogueLine moveNorthDialogue;
    [SerializeField] DialogueLine moveLeftDialogue;
    [SerializeField] DialogueLine moveSouthDialogue;
    [SerializeField] DialogueLine moveRightDialogue;
    #endregion

    public string Dialogue => dialogue;
    public DialogueLine MoveNorthDialogue { get => moveNorthDialogue; set => moveNorthDialogue = value; }
    public DialogueLine MoveLeftDialogue { get => moveLeftDialogue; set => moveLeftDialogue = value; }
    public DialogueLine MoveSouthDialogue { get => moveSouthDialogue; set => moveSouthDialogue = value; }
    public DialogueLine MoveRightDialogue { get => moveRightDialogue; set => moveRightDialogue = value; }
    #endregion

}