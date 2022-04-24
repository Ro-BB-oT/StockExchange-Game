using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NPC file", menuName = "NPC files Archive")]

public class NpcDialogue : ScriptableObject
{
    [TextArea(3, 15)]
    public string[] dialogue;
    //[TextArea(3, 15)]
    //public string[] playerDialogue;

}
