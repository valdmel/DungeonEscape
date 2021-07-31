using UnityEngine;

[CreateAssetMenu(menuName = "DialogueLine")]
public class DialogueLine : ScriptableObject
{
    #region VARIABLES
    #region SERIALIZABLE
    [Header("Dialogue Properties")]
    [SerializeField, TextArea(30, 14)] private string dialogue;
    [Header("Actions Properties")]
    [SerializeField] DialogueLine moveNorthDialogue;
    [SerializeField] DialogueLine moveLeftDialogue;
    [SerializeField] DialogueLine moveSouthDialogue;
    [SerializeField] DialogueLine moveRightDialogue;
    #endregion

    public string Dialogue => dialogue;
    public DialogueLine MoveNorthDialogue { get => moveNorthDialogue; private set => moveNorthDialogue = value; }
    public DialogueLine MoveLeftDialogue { get => moveLeftDialogue; private set => moveLeftDialogue = value; }
    public DialogueLine MoveSouthDialogue { get => moveSouthDialogue; private set => moveSouthDialogue = value; }
    public DialogueLine MoveRightDialogue { get => moveRightDialogue; private set => moveRightDialogue = value; }
    #endregion

}