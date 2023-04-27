using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(GroundCheck))]
[RequireComponent(typeof(Rigidbody2D))]
public class Gravity : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb2d;
    [SerializeField] private GroundCheck _groundCheck;
    [SerializeField] private Flipping _flipping;
    [SerializeField] private Animator _camAnimator;

    public void TryToChange(InputAction.CallbackContext ctx)
    {
        if (_groundCheck.CheckForGround())
        {
            _rb2d.gravityScale = -_rb2d.gravityScale;
            _flipping.Flip();
            _camAnimator.SetTrigger("Jump");
        }
    }

    public void Change()
    {
        _rb2d.gravityScale = -_rb2d.gravityScale;
        _flipping.Flip();
        _camAnimator.SetTrigger("Jump");
    }
}
