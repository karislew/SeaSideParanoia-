using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickableObject : Interactable
{



    public override void OnInteract()
    {
        print($"We CLICKED HORRAYY {this.name}");
    }
    
}
