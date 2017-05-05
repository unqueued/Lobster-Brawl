using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streak : MonoBehaviour{

    public int comboP1 = 0;
    private int topComboP1 = 0;

    public int comboP2 = 0;
    private int topComboP2 = 0;

    //public bool P1comboSpawn = false;
    //public bool P2comboSpawn = false;

    public Animator ComboAnimations;

    // Use this for initialization
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        if (comboP1 == 5){
            ComboAnimations.Play("Combo 5");
        }
        else if(comboP1 == 10)
        {
            ComboAnimations.Play("Combo 10");
        }
        else if(comboP1 == 15)
        {
            ComboAnimations.Play("Combo 15");
        }
        else if(comboP1 == 20)
        {
            ComboAnimations.Play("Combo 20");
        }
        else if(comboP1 == 25)
        {
            ComboAnimations.Play("Combo 25");
        }
        else if(comboP1 == 30)
        {
            ComboAnimations.Play("Combo 30");
        }
        else if(comboP1 >= 35)
        {
            ComboAnimations.Play("Combo 35");
        }
        if (comboP2 == 5)
        {
            ComboAnimations.Play("Combo 5");
        }
        else if (comboP2 == 10)
        {
            ComboAnimations.Play("Combo 10");
        }
        else if (comboP2 == 15)
        {
            ComboAnimations.Play("Combo 15");
        }
        else if (comboP2 == 20)
        {
            ComboAnimations.Play("Combo 20");
        }
        else if (comboP2 == 25)
        {
            ComboAnimations.Play("Combo 25");
        }
        else if (comboP2 == 30)
        {
            ComboAnimations.Play("Combo 30");
        }
        else if (comboP2 >= 35)
        {
            ComboAnimations.Play("Combo 35");
        }
    }

    //Players Miss
    public void P1Miss(){
        comboP1 = 0;
    }

    public void P2Miss(){
        comboP2 = 0;
    }

    //Players Hit
    public void P1Hit(){
        comboP1++;
        if (comboP1 > topComboP1){
            topComboP1 = comboP1;
        }
    }

    public void P2Hit(){
        comboP2++;
        if (comboP2 > topComboP2){
            topComboP2 = comboP2;
        }
    }

    //Get Players Combo
    public int getComboP1(){
        return comboP1;
    }

    public int getComboP2(){
        return comboP2;
    }

    //Get Players Top Combo
    public int getTopComboP1(){
        return topComboP1;
    }

    public int getTopComboP2(){
        return topComboP2;
    }
}