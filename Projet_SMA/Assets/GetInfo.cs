﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// gets list of all other agents on the field
/// </summary>

public class GetInfo : MonoBehaviour {

    public List<GameObject> barbarians;
    public List<GameObject> guards;
    public List<GameObject> villagers;
    public int hp = 100;
    public GameObject target;//or target pos?
    public GameObject attacker;

    // Use this for initialization
    void Start ()
    {
        foreach (GameObject barbarian in GameObject.FindGameObjectsWithTag("Barbarian"))
        {barbarians.Add(barbarian);}
        /*foreach (GameObject guard in GameObject.FindGameObjectsWithTag("Guard"))
        {guards.Add(guard);}*/
        foreach (GameObject villager in GameObject.FindGameObjectsWithTag("Villager"))
        {
            villagers.Add(villager);
            target = villager;

            //Debug.Log("found villager\n");
        }
        

        foreach (GameObject barbarian in GameObject.FindGameObjectsWithTag("Barbarian"))
        {barbarians.Add(barbarian);}
        foreach (GameObject guard in GameObject.FindGameObjectsWithTag("Guard"))
        {guards.Add(guard);}
        foreach (GameObject villager in GameObject.FindGameObjectsWithTag("Villager"))
        {villagers.Add(villager);}
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
