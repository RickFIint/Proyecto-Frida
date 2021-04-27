// GENERATED AUTOMATICALLY FROM 'Assets/Control/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ca4796fe-2531-42f4-9b15-cc42d03d4b83"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7dea2a44-4c2a-41b8-a1b0-abe4c207c3cb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation X"",
                    ""type"": ""Value"",
                    ""id"": ""e3adb08e-1009-4702-9bf2-2031df7441f2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation Y"",
                    ""type"": ""Value"",
                    ""id"": ""33ac0629-8ff4-4ba1-bec1-5bad183ba624"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""5200fa4a-2241-45fa-8893-f6785e5bfb0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""192bbfee-67f8-4c7e-aa82-bb086dfa6c36"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""6b53b800-e3ea-4719-a614-06023900e501"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""68970c33-e541-4993-a47f-e41f41fd82dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""31858818-25b8-4307-89c1-89574ab8023f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMenu"",
                    ""type"": ""Button"",
                    ""id"": ""1da33e43-45e3-4f86-907a-c1acabef85b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleButton"",
                    ""type"": ""Button"",
                    ""id"": ""b5ad7080-8d8a-4195-bf8d-8a32aee41590"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""1)Button"",
                    ""type"": ""Button"",
                    ""id"": ""77cf3f9f-bbe2-44e7-ad54-64cad94ce9a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""2)Button"",
                    ""type"": ""Button"",
                    ""id"": ""a5d0bec1-d87c-43e2-b49d-398e8e0f0614"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""3)Button"",
                    ""type"": ""Button"",
                    ""id"": ""7be14338-0fa3-4e9b-8b15-24f289520741"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f82b5224-e5af-4b98-b703-29ce93920310"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""560f585d-e3c9-4d6a-81d6-639528e4af7e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d8dd1c31-ee70-49ef-8362-b0a24d8154f6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""407cb36d-751d-4877-99c8-e998cf07b4d2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ac3c850c-909d-48e9-bb04-eebdb5a503f2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0f49dd6d-2b51-4dff-af7f-bf0db52bddcf"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Rotation X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6369c9c6-5f0f-4eec-99d3-3b9a68bff2fb"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Rotation Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24e137c7-0cb2-44d1-a49b-0d355d1bcc1b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af8821e8-2898-4cf3-93fb-37050849bb49"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71d0a26e-d8e3-47bc-83a0-a72f2329becf"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""449b8a65-0944-4696-b53f-96cfc242007c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9be2f546-f730-419d-9e43-34ae9ff3241d"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eef04e8-486d-4474-a9c3-7b17f336038f"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""CameraMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""298ac0a1-df9f-4f20-a5e0-44ebd5821d0a"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""1)Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f6eddaf-02c3-44c6-9765-86f58c09e0a8"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""2)Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""94d32e11-c6b5-4789-a36a-4724e4ccdf0a"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""3)Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b21a8f4b-8af6-4f46-9c90-f85311b1f0c9"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""MiddleButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Debug"",
            ""id"": ""e63c9ff9-ea10-483d-9b6d-228730177a06"",
            ""actions"": [
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""66c18146-d94f-405b-9ba1-3fcac7c4a7d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""8eba3c53-e553-4a15-9a1f-01895dfa44f2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""180dc731-4add-4a98-b7fb-1e8394eee1b6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c16518f6-acd8-4984-a671-4f77373618cb"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TableOfClues"",
            ""id"": ""58b96a57-4966-4a9d-8eff-424d29e46526"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""03a1adba-5feb-48f6-a50f-a0d0a6c33346"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""c59c06df-e085-45b6-afa3-4429d6ad8c93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4cdc56aa-b56a-4dc3-819e-8eca2c7dc41f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45058c0b-5b2f-4620-a206-fd74a44f2de0"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Teclado y Ratón"",
            ""bindingGroup"": ""Teclado y Ratón"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_RotationX = m_Player.FindAction("Rotation X", throwIfNotFound: true);
        m_Player_RotationY = m_Player.FindAction("Rotation Y", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Crouch = m_Player.FindAction("Crouch", throwIfNotFound: true);
        m_Player_RightClick = m_Player.FindAction("RightClick", throwIfNotFound: true);
        m_Player_LeftClick = m_Player.FindAction("LeftClick", throwIfNotFound: true);
        m_Player_CameraMenu = m_Player.FindAction("CameraMenu", throwIfNotFound: true);
        m_Player_MiddleButton = m_Player.FindAction("MiddleButton", throwIfNotFound: true);
        m_Player__1Button = m_Player.FindAction("1)Button", throwIfNotFound: true);
        m_Player__2Button = m_Player.FindAction("2)Button", throwIfNotFound: true);
        m_Player__3Button = m_Player.FindAction("3)Button", throwIfNotFound: true);
        // Debug
        m_Debug = asset.FindActionMap("Debug", throwIfNotFound: true);
        m_Debug_LeftClick = m_Debug.FindAction("LeftClick", throwIfNotFound: true);
        m_Debug_Escape = m_Debug.FindAction("Escape", throwIfNotFound: true);
        // TableOfClues
        m_TableOfClues = asset.FindActionMap("TableOfClues", throwIfNotFound: true);
        m_TableOfClues_MousePosition = m_TableOfClues.FindAction("MousePosition", throwIfNotFound: true);
        m_TableOfClues_LeftClick = m_TableOfClues.FindAction("LeftClick", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_RotationX;
    private readonly InputAction m_Player_RotationY;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Crouch;
    private readonly InputAction m_Player_RightClick;
    private readonly InputAction m_Player_LeftClick;
    private readonly InputAction m_Player_CameraMenu;
    private readonly InputAction m_Player_MiddleButton;
    private readonly InputAction m_Player__1Button;
    private readonly InputAction m_Player__2Button;
    private readonly InputAction m_Player__3Button;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @RotationX => m_Wrapper.m_Player_RotationX;
        public InputAction @RotationY => m_Wrapper.m_Player_RotationY;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Crouch => m_Wrapper.m_Player_Crouch;
        public InputAction @RightClick => m_Wrapper.m_Player_RightClick;
        public InputAction @LeftClick => m_Wrapper.m_Player_LeftClick;
        public InputAction @CameraMenu => m_Wrapper.m_Player_CameraMenu;
        public InputAction @MiddleButton => m_Wrapper.m_Player_MiddleButton;
        public InputAction @_1Button => m_Wrapper.m_Player__1Button;
        public InputAction @_2Button => m_Wrapper.m_Player__2Button;
        public InputAction @_3Button => m_Wrapper.m_Player__3Button;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @RotationX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationX;
                @RotationX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationX;
                @RotationX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationX;
                @RotationY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationY;
                @RotationY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationY;
                @RotationY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationY;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCrouch;
                @RightClick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @LeftClick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @CameraMenu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraMenu;
                @CameraMenu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraMenu;
                @CameraMenu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraMenu;
                @MiddleButton.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMiddleButton;
                @MiddleButton.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMiddleButton;
                @MiddleButton.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMiddleButton;
                @_1Button.started -= m_Wrapper.m_PlayerActionsCallbackInterface.On_1Button;
                @_1Button.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.On_1Button;
                @_1Button.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.On_1Button;
                @_2Button.started -= m_Wrapper.m_PlayerActionsCallbackInterface.On_2Button;
                @_2Button.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.On_2Button;
                @_2Button.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.On_2Button;
                @_3Button.started -= m_Wrapper.m_PlayerActionsCallbackInterface.On_3Button;
                @_3Button.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.On_3Button;
                @_3Button.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.On_3Button;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RotationX.started += instance.OnRotationX;
                @RotationX.performed += instance.OnRotationX;
                @RotationX.canceled += instance.OnRotationX;
                @RotationY.started += instance.OnRotationY;
                @RotationY.performed += instance.OnRotationY;
                @RotationY.canceled += instance.OnRotationY;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @CameraMenu.started += instance.OnCameraMenu;
                @CameraMenu.performed += instance.OnCameraMenu;
                @CameraMenu.canceled += instance.OnCameraMenu;
                @MiddleButton.started += instance.OnMiddleButton;
                @MiddleButton.performed += instance.OnMiddleButton;
                @MiddleButton.canceled += instance.OnMiddleButton;
                @_1Button.started += instance.On_1Button;
                @_1Button.performed += instance.On_1Button;
                @_1Button.canceled += instance.On_1Button;
                @_2Button.started += instance.On_2Button;
                @_2Button.performed += instance.On_2Button;
                @_2Button.canceled += instance.On_2Button;
                @_3Button.started += instance.On_3Button;
                @_3Button.performed += instance.On_3Button;
                @_3Button.canceled += instance.On_3Button;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Debug
    private readonly InputActionMap m_Debug;
    private IDebugActions m_DebugActionsCallbackInterface;
    private readonly InputAction m_Debug_LeftClick;
    private readonly InputAction m_Debug_Escape;
    public struct DebugActions
    {
        private @InputMaster m_Wrapper;
        public DebugActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftClick => m_Wrapper.m_Debug_LeftClick;
        public InputAction @Escape => m_Wrapper.m_Debug_Escape;
        public InputActionMap Get() { return m_Wrapper.m_Debug; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DebugActions set) { return set.Get(); }
        public void SetCallbacks(IDebugActions instance)
        {
            if (m_Wrapper.m_DebugActionsCallbackInterface != null)
            {
                @LeftClick.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnLeftClick;
                @Escape.started -= m_Wrapper.m_DebugActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_DebugActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_DebugActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_DebugActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public DebugActions @Debug => new DebugActions(this);

    // TableOfClues
    private readonly InputActionMap m_TableOfClues;
    private ITableOfCluesActions m_TableOfCluesActionsCallbackInterface;
    private readonly InputAction m_TableOfClues_MousePosition;
    private readonly InputAction m_TableOfClues_LeftClick;
    public struct TableOfCluesActions
    {
        private @InputMaster m_Wrapper;
        public TableOfCluesActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePosition => m_Wrapper.m_TableOfClues_MousePosition;
        public InputAction @LeftClick => m_Wrapper.m_TableOfClues_LeftClick;
        public InputActionMap Get() { return m_Wrapper.m_TableOfClues; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TableOfCluesActions set) { return set.Get(); }
        public void SetCallbacks(ITableOfCluesActions instance)
        {
            if (m_Wrapper.m_TableOfCluesActionsCallbackInterface != null)
            {
                @MousePosition.started -= m_Wrapper.m_TableOfCluesActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_TableOfCluesActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_TableOfCluesActionsCallbackInterface.OnMousePosition;
                @LeftClick.started -= m_Wrapper.m_TableOfCluesActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_TableOfCluesActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_TableOfCluesActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_TableOfCluesActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public TableOfCluesActions @TableOfClues => new TableOfCluesActions(this);
    private int m_TecladoyRatónSchemeIndex = -1;
    public InputControlScheme TecladoyRatónScheme
    {
        get
        {
            if (m_TecladoyRatónSchemeIndex == -1) m_TecladoyRatónSchemeIndex = asset.FindControlSchemeIndex("Teclado y Ratón");
            return asset.controlSchemes[m_TecladoyRatónSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotationX(InputAction.CallbackContext context);
        void OnRotationY(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnCameraMenu(InputAction.CallbackContext context);
        void OnMiddleButton(InputAction.CallbackContext context);
        void On_1Button(InputAction.CallbackContext context);
        void On_2Button(InputAction.CallbackContext context);
        void On_3Button(InputAction.CallbackContext context);
    }
    public interface IDebugActions
    {
        void OnLeftClick(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
    public interface ITableOfCluesActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
    }
}
