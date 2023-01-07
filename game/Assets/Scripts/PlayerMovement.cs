using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
[SerializeField] private float _min_speed = 400;
    [SerializeField] private float _max_speed = 1150;
    [SerializeField] private float _turnSpeed = 180;
    [SerializeField] private float _acceleration = 25;
    private float _current_speed;
    private PlayerInput _playerInput;
    private InputAction _fire_action;
    private InputAction _moveAction;
    public Bullet bullet;
    public GameObject pulse;
    private AudioSource audiosource;

    private Rigidbody2D _rb_head;
    private void Awake() {
        _playerInput = GetComponent<PlayerInput>();
        _rb_head = GetComponent<Rigidbody2D>();
        audiosource = GetComponent<AudioSource>();
        _fire_action = _playerInput.actions["Action"];

        _moveAction = _playerInput.actions["Turn"];
    }

    void Start()
    {
        _current_speed = _min_speed;
        _fire_action.performed += _ => shoot();
        InvokeRepeating("createPulse", 1.0f, 4.0f);
    }

    void FixedUpdate()
    {
        Movement();
       
    }

    private void Movement()
    {   
        Vector2 turnInput = _moveAction.ReadValue<Vector2>();
        // turnInput = [Horizontal, Vertical]
        if (turnInput[1] != 0)
        {
            // if statement in assignment, if vertical greater than 0 add accel. if less - accel
            _current_speed += turnInput[1] > 0 ? _acceleration : -_acceleration;
            if (_current_speed < _min_speed) _current_speed = _min_speed;
            if (_current_speed > _max_speed) _current_speed = _max_speed;
        }
        // get the head of the snake and add velocity to it.
        _rb_head.velocity = _rb_head.transform.right * _current_speed * Time.deltaTime;
        if (turnInput[0] != 0)
        {
            _rb_head.transform.Rotate(new Vector3(0, 0, -_turnSpeed * Time.deltaTime * turnInput[0]));
        }
        // Dont need scaling
        // if (_current_speed > _min_speed) 
        // {
        //     var scale = _current_speed / _min_speed > 2f ? 2f : _current_speed / _min_speed;
        //     _rb_head.transform.localScale = new Vector3(scale, 1, 1);
        // }
    } 
// New change
    public void shoot(){
        var tempBullet = Instantiate(bullet, this.transform.position, this.transform.rotation);
        tempBullet.PassInfo(this.transform.rotation * Vector3.right);
    }

    public void createPulse(){
        Instantiate(pulse, this.transform.position, this.transform.rotation);
        audiosource.Play();
    }

    
}
