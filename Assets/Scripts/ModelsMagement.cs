using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelsMagement : MonoBehaviour
{
    public GameObject spawnedObject;
    private int buttonIndex=0;

    public void ButtonPresed(int getIndex)
    {
        buttonIndex = getIndex;

        if (buttonIndex == 0)
        {
            spawnedObject.transform.GetChild(0).gameObject.SetActive(true);
            spawnedObject.transform.GetChild(1).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(2).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(3).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(4).gameObject.SetActive(false);
        }
        else if (buttonIndex == 1)
        {

            spawnedObject.transform.GetChild(0).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(1).gameObject.SetActive(true);
            spawnedObject.transform.GetChild(2).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(3).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(4).gameObject.SetActive(false);
        }
        else if (buttonIndex == 2)
        {

            spawnedObject.transform.GetChild(0).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(1).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(2).gameObject.SetActive(true);
            spawnedObject.transform.GetChild(3).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(4).gameObject.SetActive(false);
        }
        else if (buttonIndex == 3)
        {

            spawnedObject.transform.GetChild(0).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(1).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(2).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(3).gameObject.SetActive(true);
            spawnedObject.transform.GetChild(4).gameObject.SetActive(false);
        }
        else if (buttonIndex == 4)
        {

            spawnedObject.transform.GetChild(0).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(1).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(2).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(3).gameObject.SetActive(false);
            spawnedObject.transform.GetChild(4).gameObject.SetActive(true);
        }
    }
}
