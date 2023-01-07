//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/input_controller.inputactions
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

public partial class @Input_controller : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input_controller()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""input_controller"",
    ""maps"": [
        {
            ""name"": ""main"",
            ""id"": ""268d8aaa-b4d2-421f-896d-b309d3787073"",
            ""actions"": [
                {
                    ""name"": ""forward"",
                    ""type"": ""Value"",
                    ""id"": ""a3797bc4-aae6-46c2-af40-666622728aff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""backward"",
                    ""type"": ""Button"",
                    ""id"": ""49626b9a-fd0d-42cb-9ae2-745efe243aa5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""rotate_left"",
                    ""type"": ""Button"",
                    ""id"": ""c9bc56de-aa26-45ac-8d66-316264c62f81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""rotate_right"",
                    ""type"": ""Button"",
                    ""id"": ""dc1a2255-aa74-46e7-a8b7-309381050fa8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""action"",
                    ""type"": ""Button"",
                    ""id"": ""65d861d2-18c0-45f8-aeac-dc78674bd831"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d4763bfe-5c8d-452b-a560-64eb29ce27c4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f66c033d-7cf1-462c-984d-391806895fa7"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3650634d-3772-4064-bd5e-e0393edf364a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d40c6ceb-25d4-46e7-9405-c05f7d45bb3b"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""backward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe4eb520-9b30-4ee5-addd-66ced9919849"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""rotate_left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83849cd4-1478-43bd-a1b8-ac3c52002c88"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""rotate_left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d25ca70a-d2e2-4f6d-bff5-47a199930c55"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""rotate_right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""becd6f9e-46a1-4786-84eb-e5de77115288"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""rotate_right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7027746d-adf7-43df-84fa-5c83b16235b5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // main
        m_main = asset.FindActionMap("main", throwIfNotFound: true);
        m_main_forward = m_main.FindAction("forward", throwIfNotFound: true);
        m_main_backward = m_main.FindAction("backward", throwIfNotFound: true);
        m_main_rotate_left = m_main.FindAction("rotate_left", throwIfNotFound: true);
        m_main_rotate_right = m_main.FindAction("rotate_right", throwIfNotFound: true);
        m_main_action = m_main.FindAction("action", throwIfNotFound: true);
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

    // main
    private readonly InputActionMap m_main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_main_forward;
    private readonly InputAction m_main_backward;
    private readonly InputAction m_main_rotate_left;
    private readonly InputAction m_main_rotate_right;
    private readonly InputAction m_main_action;
    public struct MainActions
    {
        private @Input_controller m_Wrapper;
        public MainActions(@Input_controller wrapper) { m_Wrapper = wrapper; }
        public InputAction @forward => m_Wrapper.m_main_forward;
        public InputAction @backward => m_Wrapper.m_main_backward;
        public InputAction @rotate_left => m_Wrapper.m_main_rotate_left;
        public InputAction @rotate_right => m_Wrapper.m_main_rotate_right;
        public InputAction @action => m_Wrapper.m_main_action;
        public InputActionMap Get() { return m_Wrapper.m_main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @forward.started -= m_Wrapper.m_MainActionsCallbackInterface.OnForward;
                @forward.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnForward;
                @forward.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnForward;
                @backward.started -= m_Wrapper.m_MainActionsCallbackInterface.OnBackward;
                @backward.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnBackward;
                @backward.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnBackward;
                @rotate_left.started -= m_Wrapper.m_MainActionsCallbackInterface.OnRotate_left;
                @rotate_left.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnRotate_left;
                @rotate_left.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnRotate_left;
                @rotate_right.started -= m_Wrapper.m_MainActionsCallbackInterface.OnRotate_right;
                @rotate_right.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnRotate_right;
                @rotate_right.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnRotate_right;
                @action.started -= m_Wrapper.m_MainActionsCallbackInterface.OnAction;
                @action.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnAction;
                @action.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @forward.started += instance.OnForward;
                @forward.performed += instance.OnForward;
                @forward.canceled += instance.OnForward;
                @backward.started += instance.OnBackward;
                @backward.performed += instance.OnBackward;
                @backward.canceled += instance.OnBackward;
                @rotate_left.started += instance.OnRotate_left;
                @rotate_left.performed += instance.OnRotate_left;
                @rotate_left.canceled += instance.OnRotate_left;
                @rotate_right.started += instance.OnRotate_right;
                @rotate_right.performed += instance.OnRotate_right;
                @rotate_right.canceled += instance.OnRotate_right;
                @action.started += instance.OnAction;
                @action.performed += instance.OnAction;
                @action.canceled += instance.OnAction;
            }
        }
    }
    public MainActions @main => new MainActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IMainActions
    {
        void OnForward(InputAction.CallbackContext context);
        void OnBackward(InputAction.CallbackContext context);
        void OnRotate_left(InputAction.CallbackContext context);
        void OnRotate_right(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
    }
}
