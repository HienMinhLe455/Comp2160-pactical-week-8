using UnityEngine;
using UnityEngine.InputSystem;

public class Player2 : MonoBehaviour
{
    InputSystem_Actions playerActions2;
    InputAction playerMove2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerActions2 = new InputSystem_Actions();
        playerMove2 = playerActions2.Player.Move2;
    }

    private void OnEnable()
    {
        playerMove2.Enable();
    }

    private void OnDisable()
    {
        playerMove2.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerMove2.ReadValue<Vector2>());
        transform.Translate(playerMove2.ReadValue<Vector2>() * 10f * Time.deltaTime);
    }
}
