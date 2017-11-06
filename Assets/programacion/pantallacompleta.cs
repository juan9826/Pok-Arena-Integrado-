using UnityEngine;
using System.Collections;

public class pantallacompleta : MonoBehaviour
{
     public void Example()

     {
        if (Screen.fullScreen)
        {
            Debug.Log("DONE");
        }
        Screen.fullScreen = !Screen.fullScreen;
   
     }

}