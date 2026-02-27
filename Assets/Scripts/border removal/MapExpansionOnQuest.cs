using UnityEngine;

public class MapExpansionOnQuest : MonoBehaviour
{
    public string questId = "CollectCoinsQuest"; // match your actual quest ID
    public GameObject border;

    private void OnEnable()
    {
        GameEventsManager.instance.questEvents.onFinishQuest += OnQuestFinished;
    }//konec onEnable

    private void OnDisable()
    {
        GameEventsManager.instance.questEvents.onFinishQuest -= OnQuestFinished;
    }//konec onDisable

    private void OnQuestFinished(string finishedQuestId)
    {
        if (finishedQuestId == questId)
        {
            ExpandMap();
        }//konec if
    }//konec OnQuestFinished


    private void ExpandMap()
    {
        if (border != null)
        {
            Destroy(border);
            Debug.Log("Map Expanded!");
        }//konec if 
    }//konec Expand map
}//konec MapExpansionOnQuest 