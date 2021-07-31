using UnityEngine;

[CreateAssetMenu(menuName = "GameEvent")]
public class GameEvent : ScriptableObject
{
    #region VARIABLES
    #region SERIALIZABLE
    [Header("Event Properties")]
    [SerializeField] private GameObject[] ambienceSoundsToCreate;
    [SerializeField] private GameObject[] ambienceSoundsToDestroy;
    #endregion
    #endregion

    public void RunEvent()
    {
        DestroyAmbienceSounds();
        CreateAmbienceSounds();
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
}
