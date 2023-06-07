using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int isJumpingHash;

    public float characterSpeed = 1;
    public float rotateSpeed = 1;
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Slider SpeedVolume;
    public Text SpeedValue;
    public Slider RotateVolume;
    public Text RotateValue;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isJumpingHash = Animator.StringToHash("isJumping");

    }

    // Update is called once per frame
    void Update()
    {
        bool isJumping = animator.GetBool(isJumpingHash);
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool jumpPressed = Input.GetKey("space");
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");


        //Press "F1" to change in 3rd Person POV

        if (Input.GetKey(KeyCode.F1))
        {
            cam1.gameObject.SetActive(true);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(false);
        }

        if (Input.GetKey(KeyCode.F2))
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(true);
            cam3.gameObject.SetActive(false);
        }

        if (Input.GetKey(KeyCode.F3))
        {
            cam1.gameObject.SetActive(false);
            cam2.gameObject.SetActive(false);
            cam3.gameObject.SetActive(true);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, characterSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -characterSpeed);
        }

        //Make the character move forward by pressing "w"
        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }
        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        //Make the character run forward by pressing "left shift + w"
        if (!isRunning && (forwardPressed && runPressed))
        {
            transform.Translate(0, 0, characterSpeed);
            animator.SetBool(isRunningHash, true);
        }

        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool(isRunningHash, false);
        }
        //Make the character jump by pressing "space bar"
        if (!isJumping && (jumpPressed && !isWalking && !isRunning))
        {
            animator.SetBool(isJumpingHash, true);
        }

        if (isJumping && (!jumpPressed || !isWalking || !isRunning))
        {
            animator.SetBool(isJumpingHash, false);
        }

        //Make the character turn left by pressing "a"
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Rotate(0, -rotateSpeed, 0);
        }

        //Make the character turn left by pressing "d"
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed, 0);
        }
        
    }
    public void SpeedChange()
    {
        characterSpeed = SpeedVolume.value;
        SpeedValue.text = characterSpeed.ToString();

    }

    public void RotateChange()
    {
        rotateSpeed = RotateVolume.value;
        RotateValue.text = rotateSpeed.ToString();

    }
}
