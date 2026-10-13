using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float baseSpeed = 15f;
    [SerializeField] float boostSpeed =20f;
    InputAction moveAction;
    Rigidbody2D myRigidbody2D;
    Vector2 moveVector;
    SurfaceEffector2D surfaceEffector2D;
    bool canControlPlayer = true;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        myRigidbody2D = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        // (x,y)
        // (0.2, 0.5)
        if (canControlPlayer)
        {
            RotatePlayer();
            BoostPlayer();
        }
        

    }

    void RotatePlayer()
    {      
        moveVector = moveAction.ReadValue<Vector2>();
        if (moveVector.x < 0)
        {
            myRigidbody2D.AddTorque(torqueAmount);
        }
        else if (moveVector.x > 0)
        {
            myRigidbody2D.AddTorque(-torqueAmount);
        }
    }

    void BoostPlayer()
    {
        if (moveVector.y > 0)
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else if (moveVector.y <= 0)
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }
    
    public void DisableControls()
    {
        canControlPlayer = false;
    }
}
