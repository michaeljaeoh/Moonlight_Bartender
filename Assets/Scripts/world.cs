using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class world : MonoBehaviour {
    public bool mouseBusy, done;
    public NormalCustomer Customer;
    public AlcoholicCustomer Alcoholic;
    public Chia chia; 
    public int customer_count = 0;
    public Stack<customer> customer_stack;
    public List<string> drinkOptions, foodOptions;
    public static float timeLeft;
    public static int moneyEarned = 0;
    GameObject time;
    GameObject star;
    public static int star1;
    public static int star2;
    public static int star3;
    private bool paid;

    public static bool isLevel1, isLevel2, isLevel3;


    void Awake()
    {
        paid = false;
        moneyEarned = 0;
        timeLeft = 20.0f;
        time = transform.Find("Canvas/end dialogue").gameObject;

        time.SetActive(false);
        Physics.queriesHitTriggers = true;
        customer_stack = new Stack<customer>();
        drinkOptions = new List<string>();
        foodOptions = new List<string>();
    }

    // Update is called once per frame
    void Update() {
        if (done)
        {
            timeLeft = 0;
            if (!paid)
            {
                GameManager.money += moneyEarned;
                print(GameManager.money);
                paid = true;
            }
            time.SetActive(true);
            if (moneyEarned >= star3)
            {
                star = transform.Find("Canvas/end dialogue/star/star (3)").gameObject;
                star.SetActive(true);
                if (isLevel1) { GameManager.level_1_star = 3; }
                else if (isLevel2) { GameManager.level_2_star = 3; }
                else if (isLevel3) { GameManager.level_3_star = 3; }

            }
            else if ((moneyEarned >= star2) && (moneyEarned < star3))
            {
                star = transform.Find("Canvas/end dialogue/star/star (2)").gameObject;
                star.SetActive(true);
                if (isLevel1 && GameManager.level_1_star < 3) { GameManager.level_1_star = 2; }
                else if (isLevel2 && GameManager.level_2_star < 3) { GameManager.level_2_star = 2; }
                else if (isLevel3 && GameManager.level_2_star < 3) { GameManager.level_3_star = 2; }
            }
            else if ((moneyEarned >= star1) && (moneyEarned < star2))
            {
                star = transform.Find("Canvas/end dialogue/star/star (1)").gameObject;
                star.SetActive(true);
                if (isLevel1 && GameManager.level_1_star < 2) { GameManager.level_1_star = 1; }
                else if (isLevel2 && GameManager.level_2_star < 2) { GameManager.level_2_star = 1; }
                else if (isLevel3 && GameManager.level_3_star < 2) { GameManager.level_3_star = 1; }
            }
            
        }
        if (timeLeft > 0)
            timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            done = true;
           // GameObject time = transform.Find("Canvas/end dialogue").gameObject;            
        }


        if (Input.GetMouseButton(0)) {
            mouseBusy = false;
            //print(mouseBusy);
        }

        if (!done && customer_count < 3 && customer_stack.Count != 0)
        {
            customer newCustomer = customer_stack.Pop();
            Instantiate(newCustomer);
            newCustomer.staticWorldSetupMethod(this);
        }

        if (customer_stack.Count == 0 && customer_count == 0)
            done = true;
    }

    public bool getMouseBusy() {
        //print(mouseBusy);
        return mouseBusy;
    }

    public void setMouseBusy() {
        //print("Mouse busy");
        mouseBusy = true;
    }
}
