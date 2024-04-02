using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestObject : MonoBehaviour
{
    private bool inTrigger = false;

    public List<int> availableQuestIDs = new List<int>();
    public List<int> receivableQuestIDs = new List<int>();

    public GameObject questMarker;
    public Image theImage;

    public Sprite questAvailableSprite;
    public Sprite questReceivableSprite;

    // Start is called before the first frame update
    void Start()
    {
        SetQuestMarker();
    }

   public void SetQuestMarker()
    {
        if (QuestManager.questManager.CheckCompletedQuests(this))
        {
            questMarker.SetActive(true);
            theImage.sprite = questAvailableSprite;
        }
        else if (QuestManager.questManager.CheckAvailableQuests(this))
        {
            questMarker.SetActive(true);
            theImage.sprite = questAvailableSprite;
        }
        else if (QuestManager.questManager.CheckAcceptedQuests(this))
        {
            questMarker.SetActive(true);
            theImage.sprite = questReceivableSprite;
        }
        else
        {
            questMarker.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        SetQuestMarker();
        if (inTrigger && Input.GetKeyDown(KeyCode.Tab))
        {
            if (!QuestUIManager.uiManager.questPanelActive)
            {

            
                //quest UI manager;
                QuestUIManager.uiManager.CheckQuests(this);
                //QuestManager.questManager.QuestRequest(this);
            }
            else if (QuestUIManager.uiManager.questPanelActive)
            {
                QuestUIManager.uiManager.HideQuestPanel();
            }

        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zaidejas")
        {
            inTrigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Zaidejas")
        {
            inTrigger = false;
        }
    }
}
