using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestUIManager : MonoBehaviour
{

    public static QuestUIManager uiManager;

    //bools
    public bool questAvailable = false;
    public bool questRunning = false;
    public bool questPanelActive = false;
    private bool questLogPanelActive = false;
    

    //panels
    public GameObject questPanel;
    public GameObject questLogPanel;

    // quest object
    private QuestObject currentQuestObject;

    //questlists
    public List<Quest> availableQuests = new List<Quest>();
    public List<Quest> activeQuests = new List<Quest>();

    //buttons
    public GameObject qButton;
    public GameObject qLogButton;
    private List<GameObject> qButtons = new List<GameObject>();

    public GameObject acceptButton;
    public GameObject giveUpButton;
    public GameObject completeButton;

    //spacer
    public Transform qButtonSpacer1; //spacer for qButton available 
    public Transform qButtonSpacer2; //spacer for qButton running
    public Transform qLogButtonSpacer; //running in qLog

    //quest info
    public Text questTitle;
    public Text questDescription;
    public Text QuestSummary;
    public Text questReward;

    //quest log info
    public Text questLogTitle;
    public Text questLogDescription;
    public Text QuestLogSummary;
    public Text questLogReward;


    public QButtonScript acceptButtonScript;
    public QButtonScript giveUpButtonScript;
    public QButtonScript completeButtonScript;

    

    private void Awake()
    {
        acceptButton = GameObject.Find("QuestCanvas").transform.Find("QuestPanel").transform.Find("QuestDescription").transform.Find("GameObject").transform.Find("AcceptButton").gameObject;
        acceptButtonScript = acceptButton.GetComponent<QButtonScript>();

        giveUpButton = GameObject.Find("QuestCanvas").transform.Find("QuestPanel").transform.Find("QuestDescription").transform.Find("GameObject").transform.Find("GiveUpButton").gameObject;
        giveUpButtonScript = giveUpButton.GetComponent<QButtonScript>();

        completeButton = GameObject.Find("QuestCanvas").transform.Find("QuestPanel").transform.Find("QuestDescription").transform.Find("GameObject").transform.Find("CompleteButton").gameObject;
        completeButtonScript = completeButton.GetComponent<QButtonScript>();

        acceptButton.SetActive(false);
        giveUpButton.SetActive(false);
        completeButton.SetActive(false);




        
        if (uiManager == null)
        {
            uiManager = this;
        }
        else if (uiManager != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        HideQuestPanel();
       
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            questLogPanelActive = !questLogPanelActive;
            showQuestLogPanel();

        }
        
        
    }
    //called from quest object
    public void CheckQuests(QuestObject questObject)
    {
        currentQuestObject = questObject;
        QuestManager.questManager.QuestRequest(questObject);
        if ((questRunning || questAvailable) && !questPanelActive)
        {
            ShowQuestPanel();
        }
        else
        {
            
        }
    }

    //show panel
    public void ShowQuestPanel()
    {
        questPanelActive = true;
        questPanel.SetActive(questPanelActive);
        //fill in the data
        FillQuestButtons();
        Time.timeScale = 0;
    }

    //quest log

    public void showQuestLogPanel()
    {
        questLogPanel.SetActive(true);
        if(questLogPanelActive && !questPanelActive)
        {
            foreach(Quest curQuest in QuestManager.questManager.currentQuestList)
            {
                GameObject questButton = Instantiate(qLogButton);
                QLogButtonScript qbutton = questButton.GetComponent<QLogButtonScript>();

                qbutton.questID = curQuest.id;
                qbutton.questTitle.text = curQuest.title;
                

                questButton.transform.SetParent(qLogButtonSpacer, false);
                qButtons.Add(questButton);

            }
        }
        else if (!questLogPanelActive && !questPanelActive)
        {
            HideQuestLogPanel();
        }
    }

    public void ShowQuestLog(Quest activeQuest)
    {
        questLogTitle.text = activeQuest.title;
        if (activeQuest.progress == Quest.QuestProgress.ACCEPTED)
        {
            questLogDescription.text = activeQuest.hint;
            QuestLogSummary.text = activeQuest.questObjective + " : " + activeQuest.questObjectiveCount + " / " + activeQuest.questObjectiveRequirement;
            questLogReward.text = "Atlygis: "+ activeQuest.CoinsReward.ToString() + " monetos ir 1 obuoliukas";

            
        }
        else if (activeQuest.progress == Quest.QuestProgress.COMPLETE)
        {
            questLogDescription.text = activeQuest.congratulation;
            QuestLogSummary.text = activeQuest.questObjective + " : " + activeQuest.questObjectiveCount + " / " + activeQuest.questObjectiveRequirement;
            questLogReward.text = "Atlygis: " + activeQuest.CoinsReward.ToString() + " monetos ir 1 obuoliukas";
        }
    }

    //hide quest panel
    public void HideQuestPanel()
    {
        questPanelActive = false;
        questAvailable = false;
        questRunning = false;

        //clear text
        questTitle.text = "";
        questDescription.text = "";
        QuestSummary.text = "";
        questReward.text = "";

        //clear lists
        availableQuests.Clear();
        activeQuests.Clear();

        //clear button list
        for (int i = 0; i < qButtons.Count; i++)
        {
            Destroy(qButtons[i]);
        }
        qButtons.Clear();
        //hide panel
        questPanel.SetActive(questPanelActive);
        Time.timeScale = 1;
    }

    //hide quest log panel
    public void HideQuestLogPanel()
    {
        questLogPanelActive = false;

        questLogTitle.text = "";
        questLogDescription.text = "";
        QuestLogSummary.text = "";

        //clear button list

        for (int i =0; i< qButtons.Count; i++)
        {
            Destroy(qButtons[i]);
        }
        qButtons.Clear();
        questLogPanel.SetActive(questLogPanelActive);
    }

    //fill buttons for quest panel
    void FillQuestButtons()
    {
        foreach(Quest availableQuest in availableQuests)
        {
            GameObject questButton = Instantiate(qButton);
            QButtonScript qBScript = questButton.GetComponent<QButtonScript>();

            qBScript.questID = availableQuest.id;
            qBScript.questTitle.text = availableQuest.title;

            questButton.transform.SetParent(qButtonSpacer1, false);
            qButtons.Add(questButton);
        }
        foreach (Quest activeQuest in activeQuests)
        {
            GameObject questButton = Instantiate(qButton);
            QButtonScript qBScript = questButton.GetComponent<QButtonScript>();

            qBScript.questID = activeQuest.id;
            qBScript.questTitle.text = activeQuest.title;

            questButton.transform.SetParent(qButtonSpacer2, false);
            qButtons.Add(questButton);
        }
    }

    //show quest on button press in quest panel
    public void ShowSelectedQuest(int questID)
    {
        for (int i =0; i <availableQuests.Count; i++)
        {
            if (availableQuests[i].id == questID)
            {
                questTitle.text = availableQuests[i].title;
                if (availableQuests[i].progress == Quest.QuestProgress.AVAILABLE)
                {
                    questDescription.text = availableQuests[i].description;
                    QuestSummary.text = availableQuests[i].questObjective + " : " + availableQuests[i].questObjectiveCount + " / " + availableQuests[i].questObjectiveRequirement;
                    questReward.text = "Atlygis: " + availableQuests[i].CoinsReward.ToString() + " monetos ir 1 obuoliukas";
                    
                }
            }
        }

        for (int i = 0; i < activeQuests.Count; i++)
        {
            if (activeQuests[i].id == questID)
            {
                questTitle.text = activeQuests[i].title;
                if (activeQuests[i].progress == Quest.QuestProgress.ACCEPTED)
                {
                    questDescription.text = activeQuests[i].hint;
                    QuestSummary.text = activeQuests[i].questObjective + " : " + activeQuests[i].questObjectiveCount + " / " + activeQuests[i].questObjectiveRequirement;
                    questReward.text = "Atlygis: " + activeQuests[i].CoinsReward.ToString()+  " monetos ir 1 obuoliukas";

                }
                else if (activeQuests[i].progress == Quest.QuestProgress.COMPLETE)
                {
                    questDescription.text = activeQuests[i].congratulation;
                    QuestSummary.text = activeQuests[i].questObjective + " : " + activeQuests[i].questObjectiveCount + " / " + activeQuests[i].questObjectiveRequirement;
                    questReward.text = "Atlygis: " + activeQuests[i].CoinsReward.ToString() + " monetos ir 1 obuoliukas";
                }
            }
        }
    }
}
