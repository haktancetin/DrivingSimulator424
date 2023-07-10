//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/CustomAssets/CarControlsMap.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @CarControlsMap: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CarControlsMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CarControlsMap"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""526d9aaa-6c17-4207-b48e-17efdbbbb11a"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""edfec37c-3094-47b7-87cf-7a35066f57bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Button"",
                    ""id"": ""77b3668b-3673-4f70-b76a-a02c98614d1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Handbrake"",
                    ""type"": ""Button"",
                    ""id"": ""c91bcf56-90aa-4375-b323-928b7c237e45"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Blinkers"",
                    ""type"": ""Value"",
                    ""id"": ""c8c8e907-f025-4bc5-b53e-a4efe465154a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""Value"",
                    ""id"": ""12a1fc95-5cc5-45b1-98ed-683542ff08b1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""CameraSwitch"",
                    ""type"": ""Button"",
                    ""id"": ""8a81f6d1-0461-454f-8da2-5db86f3502ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(pressPoint=0.2,behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleTutorial"",
                    ""type"": ""Button"",
                    ""id"": ""a3c94ba2-2993-46f0-aa97-4a5d4ce0dc49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""4e36d719-704e-4222-81e5-95b370823649"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Blinkers"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5b00f76f-3b63-43dd-afed-ed1b4631e20c"",
                    ""path"": ""<Keyboard>/#(U)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Blinkers"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6b0767f0-a802-4c94-aac9-860ef60a3cd3"",
                    ""path"": ""<Keyboard>/#(ı)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Blinkers"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ea387e95-a291-42b5-97a4-de1d590f2676"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""bd02d205-a5d0-4edc-9206-7b449d5b552f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""62113e51-b584-4189-91b8-33629d6d4b81"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a6d5d726-8f2d-422b-93a0-12e074e3e581"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""24a13564-129b-44a3-b973-12bcb47105f7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d247fd36-df24-4b81-9566-f3da00211791"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""40f4df03-264f-4d6a-8331-ad0bd5e87e0f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ecf1cc81-6e1f-46d5-be01-803c60ecd724"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ba6a8b6-49ac-480a-83a2-a7a9ef03826a"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8840ed96-6b79-43a3-8a45-7d2468c2bd8b"",
                    ""path"": ""<Keyboard>/#(T)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleTutorial"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Accelerate = m_PlayerControls.FindAction("Accelerate", throwIfNotFound: true);
        m_PlayerControls_Turn = m_PlayerControls.FindAction("Turn", throwIfNotFound: true);
        m_PlayerControls_Handbrake = m_PlayerControls.FindAction("Handbrake", throwIfNotFound: true);
        m_PlayerControls_Blinkers = m_PlayerControls.FindAction("Blinkers", throwIfNotFound: true);
        m_PlayerControls_CameraMovement = m_PlayerControls.FindAction("CameraMovement", throwIfNotFound: true);
        m_PlayerControls_CameraSwitch = m_PlayerControls.FindAction("CameraSwitch", throwIfNotFound: true);
        m_PlayerControls_ToggleTutorial = m_PlayerControls.FindAction("ToggleTutorial", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private List<IPlayerControlsActions> m_PlayerControlsActionsCallbackInterfaces = new List<IPlayerControlsActions>();
    private readonly InputAction m_PlayerControls_Accelerate;
    private readonly InputAction m_PlayerControls_Turn;
    private readonly InputAction m_PlayerControls_Handbrake;
    private readonly InputAction m_PlayerControls_Blinkers;
    private readonly InputAction m_PlayerControls_CameraMovement;
    private readonly InputAction m_PlayerControls_CameraSwitch;
    private readonly InputAction m_PlayerControls_ToggleTutorial;
    public struct PlayerControlsActions
    {
        private @CarControlsMap m_Wrapper;
        public PlayerControlsActions(@CarControlsMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_PlayerControls_Accelerate;
        public InputAction @Turn => m_Wrapper.m_PlayerControls_Turn;
        public InputAction @Handbrake => m_Wrapper.m_PlayerControls_Handbrake;
        public InputAction @Blinkers => m_Wrapper.m_PlayerControls_Blinkers;
        public InputAction @CameraMovement => m_Wrapper.m_PlayerControls_CameraMovement;
        public InputAction @CameraSwitch => m_Wrapper.m_PlayerControls_CameraSwitch;
        public InputAction @ToggleTutorial => m_Wrapper.m_PlayerControls_ToggleTutorial;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Add(instance);
            @Accelerate.started += instance.OnAccelerate;
            @Accelerate.performed += instance.OnAccelerate;
            @Accelerate.canceled += instance.OnAccelerate;
            @Turn.started += instance.OnTurn;
            @Turn.performed += instance.OnTurn;
            @Turn.canceled += instance.OnTurn;
            @Handbrake.started += instance.OnHandbrake;
            @Handbrake.performed += instance.OnHandbrake;
            @Handbrake.canceled += instance.OnHandbrake;
            @Blinkers.started += instance.OnBlinkers;
            @Blinkers.performed += instance.OnBlinkers;
            @Blinkers.canceled += instance.OnBlinkers;
            @CameraMovement.started += instance.OnCameraMovement;
            @CameraMovement.performed += instance.OnCameraMovement;
            @CameraMovement.canceled += instance.OnCameraMovement;
            @CameraSwitch.started += instance.OnCameraSwitch;
            @CameraSwitch.performed += instance.OnCameraSwitch;
            @CameraSwitch.canceled += instance.OnCameraSwitch;
            @ToggleTutorial.started += instance.OnToggleTutorial;
            @ToggleTutorial.performed += instance.OnToggleTutorial;
            @ToggleTutorial.canceled += instance.OnToggleTutorial;
        }

        private void UnregisterCallbacks(IPlayerControlsActions instance)
        {
            @Accelerate.started -= instance.OnAccelerate;
            @Accelerate.performed -= instance.OnAccelerate;
            @Accelerate.canceled -= instance.OnAccelerate;
            @Turn.started -= instance.OnTurn;
            @Turn.performed -= instance.OnTurn;
            @Turn.canceled -= instance.OnTurn;
            @Handbrake.started -= instance.OnHandbrake;
            @Handbrake.performed -= instance.OnHandbrake;
            @Handbrake.canceled -= instance.OnHandbrake;
            @Blinkers.started -= instance.OnBlinkers;
            @Blinkers.performed -= instance.OnBlinkers;
            @Blinkers.canceled -= instance.OnBlinkers;
            @CameraMovement.started -= instance.OnCameraMovement;
            @CameraMovement.performed -= instance.OnCameraMovement;
            @CameraMovement.canceled -= instance.OnCameraMovement;
            @CameraSwitch.started -= instance.OnCameraSwitch;
            @CameraSwitch.performed -= instance.OnCameraSwitch;
            @CameraSwitch.canceled -= instance.OnCameraSwitch;
            @ToggleTutorial.started -= instance.OnToggleTutorial;
            @ToggleTutorial.performed -= instance.OnToggleTutorial;
            @ToggleTutorial.canceled -= instance.OnToggleTutorial;
        }

        public void RemoveCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    public interface IPlayerControlsActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnHandbrake(InputAction.CallbackContext context);
        void OnBlinkers(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnCameraSwitch(InputAction.CallbackContext context);
        void OnToggleTutorial(InputAction.CallbackContext context);
    }
}