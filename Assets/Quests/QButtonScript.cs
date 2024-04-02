using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QButtonScript : MonoBehaviour
{
    public int questID;
    public Text questTitle;

    //private GameObject acceptButton;
    //private GameObject giveUpButton;
    //private GameObject completeButton;

    


    //show all info
    public void ShowAllInfo()
    {
        QuestUIManager.uiManager.ShowSelectedQuest(questID);
        //accept button
        if (QuestManager.questManager.RequestAvailableQuest(questID))
        {
            QuestUIManager.uiManager.acceptButton.SetActive(true);
            QuestUIManager.uiManager.acceptButtonScript.questID = questID;
        }
        else
        {
            QuestUIManager.uiManager.acceptButton.SetActive(false);
        }
        //giveUp button
        if (QuestManager.questManager.RequestAcceptedQuest(questID))
        {
            QuestUIManager.uiManager.giveUpButton.SetActive(true);
           QuestUIManager.uiManager.giveUpButtonScript.questID = questID;
        }
        else
        {
            QuestUIManager.uiManager.giveUpButton.SetActive(false);
        }
        //complete button
        if (QuestManager.questManager.RequestCompleteQuest(questID))
        {
            QuestUIManager.uiManager.completeButton.SetActive(true);
            QuestUIManager.uiManager.completeButtonScript.questID = questID;
        }
        else
        {
            QuestUIManager.uiManager.completeButton.SetActive(false);
        }
    }

    public void AcceptQuest()
    {
        QuestManager.questManager.AcceptQuest(questID);
        QuestUIManager.uiManager.HideQuestPanel();

        //upadate all NPCs;
        QuestObject[] currentQuestNPCs = FindObjectsOfType(typeof(QuestObject)) as QuestObject[];
        foreach(QuestObject obj in currentQuestNPCs)
        {
            obj.SetQuestMarker();
        }
    }

    public void GiveUpQuest()
    {
        QuestManager.questManager.GiveUpQuest(questID);
        QuestUIManager.uiManager.HideQuestPanel();

        //upadate all NPCs;
        QuestObject[] currentQuestNPCs = FindObjectsOfType(typeof(QuestObject)) as QuestObject[];
        foreach (QuestObject obj in currentQuestNPCs)
        {
            obj.SetQuestMarker();
        }
    }

    public void CompleteQuest()
    {
        QuestManager.questManager.CompleteQuest(questID);
        QuestUIManager.uiManager.HideQuestPanel();

        //upadate all NPCs;
        QuestObject[] currentQuestNPCs = FindObjectsOfType(typeof(QuestObject)) as QuestObject[];
        foreach (QuestObject obj in currentQuestNPCs)
        {
            obj.SetQuestMarker();
        }
    }

    public void ClosePanel()
    {
        QuestUIManager.uiManager.HideQuestPanel();

        QuestUIManager.uiManager.acceptButton.SetActive(false);
        QuestUIManager.uiManager.giveUpButton.SetActive(false);
        QuestUIManager.uiManager.completeButton.SetActive(false);

    }
}
