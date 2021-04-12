using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionDetect : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("for 1920 1080")]
    public GameObject windowOne;
    [Header("for 750 1330")] 
    public GameObject windowTwo;
    [Header("for 1125 2436")]
    public GameObject windowThree;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(Screen.width + " and " + Screen.height);
        if (Screen.width == 1920 && Screen.height == 1080)
        {
            windowOne.SetActive(true);
            windowTwo.SetActive(false);
            windowThree.SetActive(false);
        }
        else if (Screen.width == 750 && Screen.height == 1330)
        {
            windowOne.SetActive(false);
            windowTwo.SetActive(true);
            windowThree.SetActive(false);
        }
        else if (Screen.width == 1125 && Screen.height == 2436)
        {
            windowOne.SetActive(false);
            windowTwo.SetActive(false);
            windowThree.SetActive(true);
        }
            
    }
}
