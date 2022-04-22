using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class MissionOne : Mission
{
    public delegate void ChangeObjective(Objective nextObj);
    public static event ChangeObjective onChangeObj;
    private GameObject secretary;

    private Objective currentObjective;

    public event Objective.CompleteObjective onCompleteObj;

    private int currentIndex = 0;
    [SerializeField]
    private Canvas canvas;
    public MissionOne()
    {
        objectives = new List<Objective>();
        objectives.Add(new Objective("Go to the Reciptionist", 10, 10, false, this.check1));

        //objectives[0].checkIfComplete = this.x;
        objectives.Add(new Objective("Speak to the Reciptionist", 10, 10, false, this.check2));

        currentObjective = objectives[currentIndex];

        Objective.onCompleteObj += checkObjComplete;
    }
    void Start() {
        secretary = GameObject.FindGameObjectWithTag("Female NPC - Secretary");
        onCompleteObj =  currentObjective.setOnCompleteObj(this);
    }
    private void check1(GameObject player, GameObject secretary){
        if(Vector3.Distance(player.transform.position,secretary.transform.position) <= 7){
            if(onCompleteObj != null){
                onCompleteObj();
                isComplete = true;
                canvas.transform.GetChild(2).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Press E to Speak";
                canvas.transform.GetChild(2).gameObject.SetActive(true);
                //return true;
                //Debug.Log("HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH");
            }
            }else {
                //Debug.Log("RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR");
                //return false;
            }
             //return false;
    }
    private void check2(GameObject player, GameObject secretary){
        if(Vector3.Distance(player.transform.position,secretary.transform.position) <= 7 && Input.GetKeyDown(KeyCode.E)){
            if(onCompleteObj != null){
                onCompleteObj();
                isComplete = true;
                //return true;
                Debug.Log("dONE 2");
            }
            }else {
                //Debug.Log("RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR");
                //return false;
            }
             //return false;
    }
    void FixedUpdate() {
        //checkObjComplete();
        currentObjective.checkIfComplete(GameObject.FindGameObjectWithTag("Player"),secretary);
        if(currentObjective.isComplete){
            checkObjComplete();
            onCompleteObj =  currentObjective.setOnCompleteObj(this);
        }else {

        }
        Debug.Log(currentObjective.isComplete);
    }
    void checkObjComplete(){
        if(onChangeObj != null){
            Debug.Log(currentIndex + " " + objectives.Count);
                if(currentIndex < objectives.Count - 1){
                    currentIndex++;
                    currentObjective = objectives[currentIndex];
                    //objectives.Remove(objectives[objectives.IndexOf(currentObjective) - 1]);
                    onChangeObj(currentObjective);
                }else if(currentIndex == objectives.Count - 1) {
                    currentObjective = objectives[objectives.Count - 1];
                    onChangeObj(new Objective());
                     //onChangeObj(objectives[0]);
                }else {

                    Debug.Log("Done");
                    onChangeObj(new Objective());
                }
            }
    }
}
