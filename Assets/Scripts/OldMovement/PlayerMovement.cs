using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public class PlayerMovement : MonoBehaviour
{
    //Important so we can get the correct Controls
    [SerializeField]
    int PlayerID;

    [SerializeField]
    float Speed;

    ControlsManager controlsManager;
    public Animator animator;


    void Start()
    {
        //get the ControlManager in the scene
        controlsManager = FindObjectOfType<ControlsManager>();
    }

    void Update()
    {
        if (Input.GetKey(controlsManager.GetKey(PlayerID, ControlKeys.LeftKey)))
        {
            this.gameObject.GetComponent<Transform>().Translate(Vector2.left * Speed * Time.deltaTime);
            Debug.Log (PlayerID);
        }

        if (Input.GetKey(controlsManager.GetKey(PlayerID, ControlKeys.RightKey)))
        {
            this.gameObject.GetComponent<Transform>().Translate(Vector2.right * Speed * Time.deltaTime);
        }
        

        if (Input.GetKey(controlsManager.GetKey(PlayerID, ControlKeys.Action)))
        {
            Debug.Log( "" + PlayerID + " Action Fired");
        }

        if (Input.GetKey(controlsManager.GetKey(PlayerID, ControlKeys.Attack1)))
        {
            //this.gameObject.GetComponent<Transform>().Translate(Vector2.left * Speed * Time.deltaTime);
            Debug.Log (PlayerID);
            //this.gameObject.GetComponent<CharacterMovement>().ata();
        }
        
    }



  
}