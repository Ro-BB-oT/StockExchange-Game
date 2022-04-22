using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;


public class Objective
{
    public delegate void CompleteObjective();
    public static event CompleteObjective onCompleteObj;

    public string title;
    private int experiencePoints;

    private int reward;

    public bool isComplete = false;

    public Action<GameObject, GameObject> checkIfComplete;
    public Objective(){

    }
    public Objective(string title, int experiencePoints, int reward, bool isComplete,Action<GameObject, GameObject> checkIfCompleteFunc){
        this.title = title;
        this.experiencePoints = experiencePoints;
        this.reward = reward;
        this.isComplete = isComplete;
        this.checkIfComplete = checkIfCompleteFunc;
    }
    public CompleteObjective setOnCompleteObj(Mission currentMission){
        return onCompleteObj;
    }
    // public bool checkIfComplete(GameObject player, GameObject secretary){ 
    //     return true;
    // }
    // public bool checkIfComplete(GameObject player, GameObject secretary){
    //     if(Vector3.Distance(player.transform.position,secretary.transform.position) <= 7){
    //         if(onCompleteObj != null){
    //             onCompleteObj();
    //             isComplete = true;
    //             return true;
    //         }
    //             //Debug.Log("HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH");
    //         }else {
    //             return false;
    //         }
    //          return false;
    //     }
    }
