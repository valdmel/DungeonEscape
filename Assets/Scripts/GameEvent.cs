using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Game Event")]
public class GameEvent : ScriptableObject
{
    #region VARIABLES
    #region SERIALIZABLE
    [Header("Event Properties")]
    [SerializeField] private GameObject[] ambienceSoundsToCreate;
    [SerializeField] private GameObject[] ambienceSoundsToDestroy;
    [SerializeField] private UnityEvent onEventRun; 
    #endregion
    #endregion

    #region CLASS METHODS
    public void RunEvent()
    {
        DestroyAmbienceSounds();
        CreateAmbienceSounds();
        ExecuteEventActions();
    }

    private void CreateAmbienceSounds()
    {
        foreach (var ambienceSoundObject in ambienceSoundsToCreate)
        {
            var ambienceSound = Instantiate(ambienceSoundObject);
            ambienceSound.name = ambienceSound.name.Replace("(Clone)", "");
        }
    }

    private void DestroyAmbienceSounds()
    {
        foreach (var ambienceSoundObject in ambienceSoundsToDestroy)
        {
            Destroy(GameObject.Find(ambienceSoundObject.name));
        }
    }

    private void ExecuteEventActions() => onEventRun?.Invoke();
    #endregion
}
