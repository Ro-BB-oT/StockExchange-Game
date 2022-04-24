using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;
using UnityEngine.UI;

// public class DialogueManager : MonoBehaviour
// {
//     public NpcDialogue npc;
//     bool isTalking = false;
//     float distance;
//     float curResponseTracker = 0;
//     public GameObject player;
//     public GameObject dialogueUI;
//     public Text npcName;
//     public Text npcDialogueBox;
//     public Text playerName;
//     public Text playerResponse;


//     // Start is called before the first frame update
//     void Start()
//     {
//         dialogueUI.SetActive(false);
//     }

//     void OnMouseOver()
//     {
//         distance = Vector3.Distance(player.transform.position, this.transform.position);
        
//         if(distance <= 7f)
//         {
//             if(Input.GetAxis("Mouse ScrollWheel") < 0f)
//             {
//                 curResponseTracker++;
//                 if(curResponseTracker >= npc.playerDialogue.Length -1)
//                 {
//                     curResponseTracker = npc.playerDialogue.Length -1;
//                 }
//             }
//             else if(Input.GetAxis("Mouse ScrollWheel") > 0f)
//             {
//                 curResponseTracker--;
//                 if(curResponseTracker < 0)
//                 {
//                     curResponseTracker = 0;
//                 }
//             }

//             //trigger dialogue
//             if(Input.GetKeyDown(KeyCode.E) && isTalking == false)
//             {
//                 StartConversation();
//             }
//             else if(Input.GetKeyDown(KeyCode.E) && isTalking == true)
//             {
//                 EndDialogue();
//             }

//             if(curResponseTracker == 0 && npc.playerDialogue.Length >= 0)
//             {
//                 playerResponse.text = npc.playerDialogue[0];
//                 if(Input.GetKeyDown(KeyCode.Return))
//                 {
//                     npcDialogueBox.text = npc.dialogue[1];
//                 }
//             }
//             else if(curResponseTracker == 1 && npc.playerDialogue.Length >= 1)
//             {
//                 playerResponse.text = npc.playerDialogue[1];
//                 if(Input.GetKeyDown(KeyCode.Return))
//                 {
//                     npcDialogueBox.text = npc.dialogue[2];
//                 }
//             }
//             else if(curResponseTracker == 2 && npc.playerDialogue.Length >= 2)
//             {
//                 playerResponse.text = npc.playerDialogue[2];
//                 if(Input.GetKeyDown(KeyCode.Return))
//                 {
//                     npcDialogueBox.text = npc.dialogue[3];
//                 }
//             }
//         }
//         void StartConversation()
//         {
//             isTalking = true;
//             curResponseTracker = 0;
//             dialogueUI.SetActive(true);
//             npcName.text = npc.name;
//             npcDialogueBox.text = npc.dialogue[0];
//         }
//         void EndDialogue()
//         {
//             isTalking = false;
//             dialogueUI.SetActive(false);
            
//         }
//     }

    
// }
public class DialogueManager : MonoBehaviour
{
    public NpcDialogue npc;
    bool isTalking = false;
    float distance;
    float curResponseTracker = 0;
    public GameObject player;
    public GameObject dialogueUI;
    public Text npcDialogueBox;

    void Start()
        {
            dialogueUI.SetActive(false);
        }

    void OnMouseOver()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);
        
        if(distance <= 7f)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                curResponseTracker++;
                if(curResponseTracker >= npc.dialogue.Length -1)
                {
                    curResponseTracker = npc.dialogue.Length -1;
                }
            }
            // else if(Input.GetAxis("Mouse ScrollWheel") > 0f)
            // {
            //     curResponseTracker--;
            //     if(curResponseTracker < 0)
            //     {
            //         curResponseTracker = 0;
            //     }
            
            
            

            //trigger dialogue
            if(Input.GetKeyDown(KeyCode.E) && isTalking == false)
            {
                StartConversation();
            }
            else if(Input.GetKeyDown(KeyCode.Escape) && isTalking == true)
            {
                EndDialogue();
            }


            if(curResponseTracker == 0 && npc.dialogue.Length >= 0)
            {
                npcDialogueBox.text = npc.dialogue[0];
            }
            else if(curResponseTracker == 1 && npc.dialogue.Length >= 1)
            {
                npcDialogueBox.text = npc.dialogue[1];
            }
            else if(curResponseTracker == 2 && npc.dialogue.Length >= 2)
            {
                npcDialogueBox.text = npc.dialogue[2];
            }
            else if(curResponseTracker == 3 && npc.dialogue.Length >= 3)
            {
                npcDialogueBox.text = npc.dialogue[3];
            }
            else if(curResponseTracker == 4 && npc.dialogue.Length >= 4)
            {
                npcDialogueBox.text = npc.dialogue[4];
            }
            else if(curResponseTracker == 5 && npc.dialogue.Length >= 5)
            {
                npcDialogueBox.text = npc.dialogue[5];
            }
            else if(curResponseTracker == 6 && npc.dialogue.Length >= 6)
            {
                npcDialogueBox.text = npc.dialogue[6];
            }
            else if(curResponseTracker == 7 && npc.dialogue.Length >= 7)
            {
                npcDialogueBox.text = npc.dialogue[7];
            }
            else if(curResponseTracker == 8 && npc.dialogue.Length >= 8)
            {
                npcDialogueBox.text = npc.dialogue[8];
            }
            else if(curResponseTracker == 9 && npc.dialogue.Length >= 9)
            {
                npcDialogueBox.text = npc.dialogue[9];
            }
            else if(curResponseTracker == 10 && npc.dialogue.Length >= 10)
            {
                npcDialogueBox.text = npc.dialogue[10];
            }
            else if(curResponseTracker == 11 && npc.dialogue.Length >= 11)
            {
                npcDialogueBox.text = npc.dialogue[11];
            }
            else if(curResponseTracker == 12 && npc.dialogue.Length >= 12)
            {
                npcDialogueBox.text = npc.dialogue[12];
            }
            else if(curResponseTracker == 13 && npc.dialogue.Length >= 13)
            {
                npcDialogueBox.text = npc.dialogue[13];
            }
            else if(curResponseTracker == 14 && npc.dialogue.Length >= 14)
            {
                npcDialogueBox.text = npc.dialogue[14];
            }
            else if(curResponseTracker == 15 && npc.dialogue.Length >= 15)
            {
                npcDialogueBox.text = npc.dialogue[15];
            }
            
            
        }
        
}



    void StartConversation()
        {
            isTalking = true;
            curResponseTracker = 0;
            dialogueUI.SetActive(true);
            npcDialogueBox.text = npc.dialogue[0];
        }
        void EndDialogue()
        {
            isTalking = false;
            dialogueUI.SetActive(false);
            
        }
    
}