using UnityEngine;

public class ModelTouchController : MonoBehaviour
{
    [Header("Rotation Settings")]
    public float rotationSensitivity = 0.3f;
    public bool invertX = false;
    public bool invertY = false;

    [Header("Inertia")]
    public bool enableInertia = true;
    public float inertiaDecay = 5f;

    private Vector2 _lastSinglePos;
    private Vector2 _velocity;
    private bool _isDragging;
    private Camera _arCamera;

    void Start()
    {
        _arCamera = Camera.main;
    }

    void Update()
    {
        // ── Inertia بعد ما تسيب الصباع ──
        if (enableInertia && !_isDragging && _velocity.magnitude > 0.01f)
        {
            ApplyRotation(_velocity * Time.deltaTime);

            _velocity = Vector2.Lerp(
                _velocity,
                Vector2.zero,
                inertiaDecay * Time.deltaTime
            );
        }

#if UNITY_EDITOR
        HandleMouseInput();
#else
        HandleTouchInput();
#endif
    }

    // ─────────────────────────────
    // TOUCH
    // ─────────────────────────────
    void HandleTouchInput()
    {
        if (Input.touchCount == 0)
        {
            _isDragging = false;
            return;
        }

        Touch touch = Input.GetTouch(0);

        if (touch.phase == TouchPhase.Began)
        {
            _lastSinglePos = touch.position;
            _isDragging = true;
            _velocity = Vector2.zero;
        }
        else if (touch.phase == TouchPhase.Moved)
        {
            Vector2 delta = touch.position - _lastSinglePos;

            ApplyRotation(delta * rotationSensitivity);

            if (enableInertia)
                _velocity = delta / Time.deltaTime * rotationSensitivity;

            _lastSinglePos = touch.position;
        }
        else if (touch.phase == TouchPhase.Ended)
        {
            _isDragging = false;
        }
    }

    // ─────────────────────────────
    // MOUSE (Editor)
    // ─────────────────────────────
    void HandleMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _lastSinglePos = Input.mousePosition;
            _isDragging = true;
            _velocity = Vector2.zero;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector2 delta = (Vector2)Input.mousePosition - _lastSinglePos;

            ApplyRotation(delta * rotationSensitivity);

            if (enableInertia)
                _velocity = delta / Time.deltaTime * rotationSensitivity;

            _lastSinglePos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            _isDragging = false;
        }
    }

    // ─────────────────────────────
    // ROTATION
    // ─────────────────────────────
    void ApplyRotation(Vector2 delta)
    {
        float rotX = (invertY ? 1 : -1) * delta.y * rotationSensitivity;
        float rotY = (invertX ? -1 : 1) * delta.x * rotationSensitivity;

        transform.Rotate(_arCamera.transform.up, rotY, Space.World);
        transform.Rotate(_arCamera.transform.right, rotX, Space.World);
    }

    // ─────────────────────────────
    // RESET
    // ─────────────────────────────
    public void ResetTransform()
    {
        transform.localRotation = Quaternion.identity;
        _velocity = Vector2.zero;
    }
}