using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Controls _controls;

    private void OnEnable() => _controls.Enable();
    private void OnDisable() => _controls.Disable();
    private void Awake() => _controls = new Controls();
}
