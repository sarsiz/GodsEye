﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject mainUI;
    public List<GameObject> viewList = new List<GameObject>();
    //views are added to this list in a very specific order, so don't change the list indexes

    //used for username view's back button
    int currentView = -1;

    //how long after pressing the face button the categories show up
    public float categoryViewTime;

    // Start is called before the first frame update
    void Start(){
        
    }


    public void CategoryViewFromButton(){
        Invoke("MainView", categoryViewTime);
    }

    
    //disable all views
    void DeactivateAllViews(){
        //this will be replaced by an animation
        foreach (GameObject obj in viewList){
            obj.SetActive(false);
        }
    }

    void ActivateView(int viewNum){
        //this will be replace by an animation (different to the one for DeactiveAllViews)
        viewList[viewNum].SetActive(true);

        if (viewNum != 1){
            currentView = viewNum;
        }
    }


    //display the categories after the face is clicked
    //also go back to the category view from the back button in any of the category views (except the usrenames)
    public void MainView(){
        DeactivateAllViews();

        ActivateView(0);
    }


    //show the usernames
    public void UsernameView(){
        DeactivateAllViews();

        ActivateView(1);
    }


    //methods for category buttons
    public void PersonalView(){
        DeactivateAllViews();

        ActivateView(2);
    }

    public void FinancialView(){
        DeactivateAllViews();

        ActivateView(3);
    }

    public void InterestsView(){
        DeactivateAllViews();

        ActivateView(4);
    }

    public void ConnectionsView(){
        DeactivateAllViews();

        ActivateView(5);
    }


    //go back to previous view from the usernames
    public void UsernamePreviousView(){
        DeactivateAllViews();

        ActivateView(currentView);
    }


    //accept button
    public void SaveResults(){
        mainUI.SetActive(false);
    }

    //reject button
    public void DiscardResults(){
        mainUI.SetActive(false);
    }
}
