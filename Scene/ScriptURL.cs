using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptURL : MonoBehaviour
{
   public string Url;
   public void OpenUrl()
   {
       Application.OpenURL(Url);
   }
    
}
