//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input System/MainControls.inputactions
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

public partial class @MainControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MainControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControls"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""a6264b7e-cd44-4908-9ea1-141d4b3c6e29"",
            ""actions"": [
                {
                    ""name"": ""WalkDirection"",
                    ""type"": ""Value"",
                    ""id"": ""99d4b119-cb45-449b-be64-fd19b5fa1fcb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jumping"",
                    ""type"": ""Button"",
                    ""id"": ""8a6accfa-46e7-4843-b227-d68f2145b893"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprinting"",
                    ""type"": ""Button"",
                    ""id"": ""cf4574c8-d31d-4daf-81ef-07c4777805d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""f2c87f14-6a7b-4f63-aeec-ce27aa2216a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CamRot"",
                    ""type"": ""Value"",
                    ""id"": ""bd3622af-e550-42b2-b77a-ddc702b194e9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""38ca6342-1986-4632-8deb-d46fa4bba639"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""7e947113-03c7-457a-895a-66b5cf3984cf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""574bcdef-cdf8-450b-b79d-d8c84cdd8019"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1c4cbd00-1332-43f4-b6fa-14dbb46bd8f1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b5580fcd-4e4a-4919-8dfb-d59d5ceb1427"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ffeff1d9-24c1-4a91-84d5-cedcbc4df3ba"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""d2ca535d-30ad-4c5a-b75c-0c1a3fb10440"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""41e40ad4-a2d3-479d-96bd-2eeba0bc2cd2"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""39dec2c2-df2f-4991-a4ec-571cb43a157d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""645116b2-7fa4-4606-a2bd-9a502c5f5b6a"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0d84a905-8815-4629-88a2-e0e248d9f342"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5f6c7a68-d2cb-4d34-9e8d-692c6b340317"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b0e45ac-5b42-4246-bec9-5efdbda842f5"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0e58ead-c9b8-498d-85ba-cf8b55ff8968"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprinting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4927d4b-0bab-4874-96e9-47ca66ea9c1a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprinting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0accbc93-660a-4182-88ba-6148e13d4d1f"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26bc90fd-7b7c-483f-87cd-6c079df83e03"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Controller"",
                    ""id"": ""464490ad-f2e6-42a7-af25-1e259aaa5303"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CamRot"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""83903cc6-7a7a-4f82-8228-ec94827d683c"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CamRot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""021799fc-cc9d-48d2-8ec6-b3eb986cb3d7"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CamRot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""02493f98-96f1-44f6-b109-33b8b75063da"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CamRot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""96e007bd-fa96-4867-bbb7-5c5f78c7b14c"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CamRot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9a8b2422-9e7a-4eff-a8cb-998adaccb35f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.06,y=0.06)"",
                    ""groups"": """",
                    ""action"": ""CamRot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2cbec873-bd65-4796-b06e-335baee74938"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a43ab61-efd5-4be6-a33b-6c341af37a77"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_WalkDirection = m_Main.FindAction("WalkDirection", throwIfNotFound: true);
        m_Main_Jumping = m_Main.FindAction("Jumping", throwIfNotFound: true);
        m_Main_Sprinting = m_Main.FindAction("Sprinting", throwIfNotFound: true);
        m_Main_PauseMenu = m_Main.FindAction("PauseMenu", throwIfNotFound: true);
        m_Main_CamRot = m_Main.FindAction("CamRot", throwIfNotFound: true);
        m_Main_Interact = m_Main.FindAction("Interact", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_WalkDirection;
    private readonly InputAction m_Main_Jumping;
    private readonly InputAction m_Main_Sprinting;
    private readonly InputAction m_Main_PauseMenu;
    private readonly InputAction m_Main_CamRot;
    private readonly InputAction m_Main_Interact;
    public struct MainActions
    {
        private @MainControls m_Wrapper;
        public MainActions(@MainControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @WalkDirection => m_Wrapper.m_Main_WalkDirection;
        public InputAction @Jumping => m_Wrapper.m_Main_Jumping;
        public InputAction @Sprinting => m_Wrapper.m_Main_Sprinting;
        public InputAction @PauseMenu => m_Wrapper.m_Main_PauseMenu;
        public InputAction @CamRot => m_Wrapper.m_Main_CamRot;
        public InputAction @Interact => m_Wrapper.m_Main_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @WalkDirection.started -= m_Wrapper.m_MainActionsCallbackInterface.OnWalkDirection;
                @WalkDirection.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnWalkDirection;
                @WalkDirection.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnWalkDirection;
                @Jumping.started -= m_Wrapper.m_MainActionsCallbackInterface.OnJumping;
                @Jumping.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnJumping;
                @Jumping.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnJumping;
                @Sprinting.started -= m_Wrapper.m_MainActionsCallbackInterface.OnSprinting;
                @Sprinting.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnSprinting;
                @Sprinting.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnSprinting;
                @PauseMenu.started -= m_Wrapper.m_MainActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnPauseMenu;
                @CamRot.started -= m_Wrapper.m_MainActionsCallbackInterface.OnCamRot;
                @CamRot.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnCamRot;
                @CamRot.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnCamRot;
                @Interact.started -= m_Wrapper.m_MainActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @WalkDirection.started += instance.OnWalkDirection;
                @WalkDirection.performed += instance.OnWalkDirection;
                @WalkDirection.canceled += instance.OnWalkDirection;
                @Jumping.started += instance.OnJumping;
                @Jumping.performed += instance.OnJumping;
                @Jumping.canceled += instance.OnJumping;
                @Sprinting.started += instance.OnSprinting;
                @Sprinting.performed += instance.OnSprinting;
                @Sprinting.canceled += instance.OnSprinting;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
                @CamRot.started += instance.OnCamRot;
                @CamRot.performed += instance.OnCamRot;
                @CamRot.canceled += instance.OnCamRot;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnWalkDirection(InputAction.CallbackContext context);
        void OnJumping(InputAction.CallbackContext context);
        void OnSprinting(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
        void OnCamRot(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
