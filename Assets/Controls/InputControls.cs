// GENERATED AUTOMATICALLY FROM 'Assets/Controls/InputControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace FizbinRacer.Controls
{
    public class @InputControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InputControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputControls"",
    ""maps"": [
        {
            ""name"": ""PlayerOneControls"",
            ""id"": ""b14a55b6-643a-4483-942a-2d94af876fa7"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""f217e336-b4c8-4bfc-86e4-141ef4d3f934"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""9a4e5a5b-0d1a-47b7-8346-32c59c49f078"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9a2a6214-a2cb-408e-8adc-9eeae77f44df"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""21b077cd-4a7b-4921-9c0e-6f93bf0abcf3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4100c9e5-a6f1-442f-a698-7290760a3309"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8faaaf6a-876b-46e8-adee-15957671ab82"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8501ecd-64ec-400c-887c-4366e6e51034"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcc273b1-0747-47c9-85d6-acb9924678d8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""75008f53-0de9-4ac1-afab-46469fc6e763"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ab7f8f59-2ade-4f43-b8eb-5c2f88b681fe"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6070be39-e62e-4bd5-93ba-18edd859fecc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // PlayerOneControls
            m_PlayerOneControls = asset.FindActionMap("PlayerOneControls", throwIfNotFound: true);
            m_PlayerOneControls_Accelerate = m_PlayerOneControls.FindAction("Accelerate", throwIfNotFound: true);
            m_PlayerOneControls_Brake = m_PlayerOneControls.FindAction("Brake", throwIfNotFound: true);
            m_PlayerOneControls_Steer = m_PlayerOneControls.FindAction("Steer", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }

        // PlayerOneControls
        private readonly InputActionMap m_PlayerOneControls;
        private IPlayerOneControlsActions m_PlayerOneControlsActionsCallbackInterface;
        private readonly InputAction m_PlayerOneControls_Accelerate;
        private readonly InputAction m_PlayerOneControls_Brake;
        private readonly InputAction m_PlayerOneControls_Steer;
        public struct PlayerOneControlsActions
        {
            private @InputControls m_Wrapper;
            public PlayerOneControlsActions(@InputControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Accelerate => m_Wrapper.m_PlayerOneControls_Accelerate;
            public InputAction @Brake => m_Wrapper.m_PlayerOneControls_Brake;
            public InputAction @Steer => m_Wrapper.m_PlayerOneControls_Steer;
            public InputActionMap Get() { return m_Wrapper.m_PlayerOneControls; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerOneControlsActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerOneControlsActions instance)
            {
                if (m_Wrapper.m_PlayerOneControlsActionsCallbackInterface != null)
                {
                    @Accelerate.started -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnAccelerate;
                    @Accelerate.performed -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnAccelerate;
                    @Accelerate.canceled -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnAccelerate;
                    @Brake.started -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnBrake;
                    @Brake.performed -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnBrake;
                    @Brake.canceled -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnBrake;
                    @Steer.started -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnSteer;
                    @Steer.performed -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnSteer;
                    @Steer.canceled -= m_Wrapper.m_PlayerOneControlsActionsCallbackInterface.OnSteer;
                }
                m_Wrapper.m_PlayerOneControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Accelerate.started += instance.OnAccelerate;
                    @Accelerate.performed += instance.OnAccelerate;
                    @Accelerate.canceled += instance.OnAccelerate;
                    @Brake.started += instance.OnBrake;
                    @Brake.performed += instance.OnBrake;
                    @Brake.canceled += instance.OnBrake;
                    @Steer.started += instance.OnSteer;
                    @Steer.performed += instance.OnSteer;
                    @Steer.canceled += instance.OnSteer;
                }
            }
        }
        public PlayerOneControlsActions @PlayerOneControls => new PlayerOneControlsActions(this);
        public interface IPlayerOneControlsActions
        {
            void OnAccelerate(InputAction.CallbackContext context);
            void OnBrake(InputAction.CallbackContext context);
            void OnSteer(InputAction.CallbackContext context);
        }
    }
}
