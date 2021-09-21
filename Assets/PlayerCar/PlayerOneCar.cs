using FizbinRacer.Controls;
using UnityEngine;

namespace FizbinRacer.PlayerCar
{
    /// <summary>
    /// Car controls.
    /// Author: AZinman
    /// </summary>
    public class PlayerOneCar : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb = null;
        [SerializeField] private int speed = 10;
        [SerializeField] private float steerFactor = 1;

        private InputControls controls;
        private Vector2 movementInput = Vector2.zero;
        private float steerInput = 0;
        private bool accelerateInput = false;
        private bool brakeInput = false;

        void Awake()
        {
            controls = new InputControls();

            controls.PlayerOneControls.Steer.performed += ctx => steerInput = ctx.ReadValue<float>();
            controls.PlayerOneControls.Steer.canceled += ctx => steerInput = 0;

            controls.PlayerOneControls.Accelerate.performed += ctx => accelerateInput = true;
            controls.PlayerOneControls.Accelerate.canceled += ctx => accelerateInput = false;

            controls.PlayerOneControls.Brake.performed += ctx => brakeInput = true;
            controls.PlayerOneControls.Brake.canceled += ctx => brakeInput = false;
        }

        void FixedUpdate()
        {
            if (rb != null)
            {
                Vector2 inputNormalized = movementInput.normalized;

                // braking should not work as reverse gear.
                if (brakeInput && Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up)) > 0)
                {
                    rb.velocity -= (Vector2)transform.up * speed * Time.fixedDeltaTime;
                }
                else if (accelerateInput)
                {
                    rb.velocity += (Vector2)transform.up * speed * Time.fixedDeltaTime;
                }
                if (!brakeInput)
                {
                    // Stear swiftness depending on car speed.
                    rb.rotation += steerInput * Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up)) * steerFactor;
                }
            }

        }

        private void OnEnable()
        {
            controls.PlayerOneControls.Enable();
        }

        private void OnDisable()
        {
            controls.PlayerOneControls.Disable();
        }
    }
}
