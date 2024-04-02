using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    
    public enum QuestProgress { NOT_AVAILABLE, AVAILABLE, ACCEPTED, COMPLETE, DONE }

    public string title;                    //title for the quest
    public int id;                          //ID number for the quest
    public QuestProgress progress;          //state of the current quest (enum)
    public string description;              //string from our quest giver
    public string hint;                     //string from our quest giver
    public string congratulation;           //string from our quest giver
    public string summary;                  //string from our quest giver
    public int nextQuest;                   // next quest if there is one (chain quest)

    public string questObjective;           //name of the quest objective(also for remove)
    public int questObjectiveCount;         //current number of questObjective
    public int questObjectiveRequirement;   //required amount of quest objective objects

    public int expReward;
    public float CoinsReward;
    

    
}
