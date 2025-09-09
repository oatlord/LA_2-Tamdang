using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private CharacterController characterController;
    // public CharacterController muzzleController;
    public Transform muzzlePoint;
    public float playerSpeed = 2.0f;
    private float gravityValue = 9.18f;
    private float verticalVelocity;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isGrounded = characterController.isGrounded;

        if (isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = 0f;
        }

        // applying gravity all the time
        verticalVelocity -= gravityValue * Time.deltaTime;

        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        // moving by trnasforming the game object
        if (move.magnitude > 0.05f)
        {
            gameObject.transform.forward = move;
        }

        // this is for jump but idr need it its just there lmfao
        move.y = verticalVelocity;

        if (Input.anyKeyDown)
        {
            muzzlePoint.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        } 
        // muzzleController.Move(move * Time.deltaTime);
        characterController.Move(move * Time.deltaTime);
    }
}