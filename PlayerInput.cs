using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Player))]
public class PlayerInput : MonoBehaviour
{
    private Player _player;

    void Start()
    {
        _player = GetComponent<Player>();
    }

    void Update()
    {
        Vector2 directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        _player.SetDirectionalInput(directionalInput);

        if (Input.GetKeyDown(KeyCode.Space))
            _player.OnJumpInputDown();
    }
}
