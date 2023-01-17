using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    private bool keyOne = false;
    private bool keyTwo = false;
    private bool keyThree = false;

    public GameObject drawerPic;


    public void pickUpKeyOne()
    {
        Debug.Log("Got key 1");
        keyOne = true;
    }

    public void pickUpKeyTwo()
    {
        Debug.Log("Got key 2");

        keyTwo = true;
    }

    public void pickUpKeyThree()
    {
        Debug.Log("Got key 3");

        keyThree = true;
    }

    public void hasKeyOne()
    {
        if (keyOne && keyTwo && keyThree)
        {
            Debug.Log("Open drawer");
            drawerPic.SetActive(true);
        }
        else
        {
            Debug.Log("Locked!");
        }
    }
}
