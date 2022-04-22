using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionManager : MonoBehaviour
{
    [SerializeField]
    public Mission activeMission;

    public List<Mission> missions = new List<Mission>();

    private GameObject image;

    private Text currentObjectiveText;


    // Start is called before the first frame update
    void Start()
    {
        //missions = new List<Mission>();

        //missions.Add(Instantiate<Mission>(new MissionOne()));
        // activeMission = Instantiate<Mission>(missions[0]);
        activeMission = missions[0];
        image = gameObject.transform.GetChild(1).gameObject;
        Debug.Log(activeMission.objectives[0].title);
        currentObjectiveText = image.transform.GetChild(2).gameObject.GetComponent<Text>();
        currentObjectiveText.text = activeMission.objectives[0].title;
        //updateObjectives(activeMission.objectives[0]);
        MissionOne.onChangeObj += updateObjectiveTest;
    }
    void updateObjectiveTest(Objective obj){
        currentObjectiveText.text = string.IsNullOrEmpty(obj.title) ?  "" : obj.title;
    }
    void updateObjectives(Objective obj){
        Font arial;
        arial = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
        // Create the Text GameObject.
        GameObject textGO = new GameObject();
        textGO.transform.parent = image.transform;
        textGO.AddComponent<Text>();

        // Set Text component properties.
        Text text = textGO.GetComponent<Text>();
        text.font = arial;
        text.text = obj.title;
        text.fontSize = 22;
        text.alignment = TextAnchor.MiddleCenter;

        // Provide Text position and size using RectTransform.
        RectTransform rectTransform;
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(0, -10, 0);
        rectTransform.sizeDelta = new Vector2(600, 200);
        // GameObject.CreatePrimitive()
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
