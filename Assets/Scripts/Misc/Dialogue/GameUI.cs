using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    private void Awake()
    {
        EventCenter.GetInstance().AddEventListener<DialogueSO>("对话开始", OnDialogueStart);
    }

    private void OnDialogueStart(DialogueSO dialogue) 
    {
        GameObject dialoguePanel = ResMgr.GetInstance().Load<GameObject>("UI/DialoguePanel");
        dialoguePanel.transform.SetParent(transform, false);
    }

    private void OnDestroy()
    {
        EventCenter.GetInstance().RemoveEventListener<DialogueSO>("对话开始", OnDialogueStart);
    }
}
