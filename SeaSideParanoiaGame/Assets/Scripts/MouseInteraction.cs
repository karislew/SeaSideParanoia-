using System.Collections;
using System.Collections.Generic;
using GHEvtSystem;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;




public class MouseInputSystem : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    private Vector3 mousePosition;
    [SerializeField] private LayerMask layerMask;




    public void OnMouseDown()
    {
        //print($"we down fr {this.name}");
        //MouseInteract mouseInteract = new MouseInteract()

        //EventDispatcher.Instance.RaiseEvent<MouseInteract>(mouseInteract);

    }
    public void OnMouseEnter()
    {
       
       
    }
    public void OnMouseExit()
    {
       
        
    }




    // Update is called once per frame
    void Update()
    {
        //Realized that if i did OnMouseDown this script would need to be on each interactable object
        //so now im checking if the mouse if down, doing physics raycast and if it hits and interactable (layermask), 
        //since I cant click on 2D objects with the 3D raycast I added another 2D raycast to check if im clicking 
        //a 2d object. 
        //if clicked sending that mouse position and raising the event 
        if (Input.GetMouseButtonDown(0))
        {
            

            //if 3d object
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            MouseInteract mouseInteract = new MouseInteract()
            {
                raycast = ray,
                layerMask = layerMask
            };
            EventDispatcher.Instance.RaiseEvent<MouseInteract>(mouseInteract);
        


                //if 2d object





        }
   }

}



/*
Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, Mathf.Infinity, layerMask))
            {
                if (raycastHit.collider != null)
                {
                    
                    mousePosition = raycastHit.point;
                    MouseInteract mouseInteract = new MouseInteract()
                    {
                        position = mousePosition,
                        raycast = ray,
                        layerMask = layerMask
                    };
                    EventDispatcher.Instance.RaiseEvent<MouseInteract>(mouseInteract);

                    
                }
            
*/