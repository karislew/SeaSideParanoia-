using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Yarn.Unity;
public class YarnInteractable : MonoBehaviour
{
   private DialogueRunner dialogueRunner;
   public string conversationStartNode;
   private bool interactable = true;
   private bool isCurrentCoversation;
 


   public void Start()
   {
       dialogueRunner = FindAnyObjectByType<DialogueRunner>();
       dialogueRunner.onDialogueComplete.AddListener(EndConversation);
   }
   private void StartConversation()
   {
       isCurrentCoversation = true;
       dialogueRunner.StartDialogue(conversationStartNode);
   }


   private void EndConversation()
   {
       if (isCurrentCoversation)
       {
           isCurrentCoversation = false;
       }
   }


   [YarnCommand("disable")]
   public void DisableConveration()
   {
       interactable = false;
   }
   public void OnMouseDown()
   {
       print("mouse down");
       if (interactable && !dialogueRunner.IsDialogueRunning)
       {
           StartConversation();
       }


      
      
   }


  


}
