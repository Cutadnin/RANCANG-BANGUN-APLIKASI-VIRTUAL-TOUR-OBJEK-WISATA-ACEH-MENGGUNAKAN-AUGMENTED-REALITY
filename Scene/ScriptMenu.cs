using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMenu : MonoBehaviour
{
    
    public void GoToDownloadMarker (){
        Application.LoadLevel ("MenuDownloadMarker");
   
    }
     public void GoToMainMenu (){
        Application.LoadLevel ("MainMenu");
    }
    public void GoToPanduan (){
        Application.LoadLevel ("MenuPanduan");
    }
    public void GoToExitMenu (){
        Application.LoadLevel ("ExitMenu");
    }
    public void GoToVisitAceh (){
        Application.LoadLevel ("MenuVisitAceh");
    }
     public void GoToARBaiturahman (){
        Application.LoadLevel ("ARBaiturahman");
    }
    public void GoToARKapal (){
        Application.LoadLevel ("ARKapal");
    }
    public void GoToARIslamic (){
        Application.LoadLevel ("ARIslamic");
    }
     public void GoToVirtualTourBaiturahman (){
        Application.LoadLevel ("VirtualTourBaiturahman");
    }
    public void GoToVirtualTourIslamic (){
        Application.LoadLevel ("VirtualTourIslamic");
    }
     public void GoToVirtualTourKapal (){
        Application.LoadLevel ("VirtualTourKapal");
    }
    public void GoToExit (){
        Application.Quit ();
    }
}
