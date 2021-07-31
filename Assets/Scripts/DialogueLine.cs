using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "DialogueLine")]
public class DialogueLine : ScriptableObject
{
    #region VARIABLES
    #region SERIALIZABLE
    [Header("Dialogue Properties")]
    [SerializeField, TextArea(30, 14)] private string dialogue;
    [Header("Actions Properties")]
    [SerializeField] private DialogueLine moveNorthDialogue;
    [SerializeField] private DialogueLine moveLeftDialogue;
    [SerializeField] private DialogueLine moveSouthDialogue;
    [SerializeField] private DialogueLine moveRightDialogue;
    [Header("Events Properties")]
    [SerializeField] private UnityEvent onMoveNorth;
    [SerializeField] private UnityEvent onMoveLeft;
    [SerializeField] private UnityEvent onMoveSouth;
    [SerializeField] private UnityEvent onMoveRight;
    #endregion

    public string Dialogue => dialogue;
    public DialogueLine MoveNorthDialogue { get => moveNorthDialogue; private set => moveNorthDialogue = value; }
    public DialogueLine MoveLeftDialogue { get => moveLeftDialogue; private set => moveLeftDialogue = value; }
    public DialogueLine MoveSouthDialogue { get => moveSouthDialogue; private set => moveSouthDialogue = value; }
    public DialogueLine MoveRightDialogue { get => moveRightDialogue; private set => moveRightDialogue = value; }
    public UnityEvent OnMoveNorth { get => onMoveNorth; set => onMoveNorth = value; }
    public UnityEvent OnMoveLeft { get => onMoveLeft; set => onMoveLeft = value; }
    public UnityEvent OnMoveSouth { get => onMoveSouth; set => onMoveSouth = value; }
    public UnityEvent OnMoveRight { get => onMoveRight; set => onMoveRight = value; }
    #endregion

}