namespace GSGD2.Gameplay
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using GSGD2.Player;
    using UnityEngine.InputSystem;

    public class TestInputTata : MonoBehaviour
    {
        [SerializeField]
        private InputActionMapWrapper _inputActionMap = null;
        private InputAction _abilityImproverInteractionInputAction = null;

        private void OnEnable()
        {
            if (_inputActionMap.TryFindAction("AbilityImproverInteraction", out _abilityImproverInteractionInputAction) == true)
            {
                _abilityImproverInteractionInputAction.performed -= AbilityImproverInteractionInputAction_performed;
                _abilityImproverInteractionInputAction.performed += AbilityImproverInteractionInputAction_performed;
                _abilityImproverInteractionInputAction.Enable();
            }
        }

        private void OnDisable()
        {
            _abilityImproverInteractionInputAction.performed -= AbilityImproverInteractionInputAction_performed;

            _abilityImproverInteractionInputAction.Disable();
        }

        private void AbilityImproverInteractionInputAction_performed(InputAction.CallbackContext obj)
        {
            Debug.Log("Tata test");
        }
    }
}