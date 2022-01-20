namespace GSGD2.Gameplay
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using GSGD2.Player;

    public class ShopTrigger : MonoBehaviour
    {
        [SerializeField]
        private PhysicsTriggerEvent _physicsTriggerEvent = null;

        public PhysicsTriggerEvent PhysicsTriggerEvent => _physicsTriggerEvent;

        private void OnPhysicsTriggerEventEnter(PhysicsTriggerEvent _physicsTriggerEvent, Collider other)
        {
            Debug.Log("yo");
        }
    }
}