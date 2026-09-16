using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    InputSystem_Actions playerActions;
    InputAction playerMove;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerActions = new InputSystem_Actions();
        playerMove = playerActions.Player.Move;
    }

    private void OnEnable()
    {
        playerMove.Enable();
    }

    private void OnDisable()
    {
        playerMove.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerMove.ReadValue<Vector2>());
        transform.Translate(playerMove.ReadValue<Vector2>() * 10f * Time.deltaTime);
    }
}
