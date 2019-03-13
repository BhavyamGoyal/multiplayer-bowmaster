﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WeaponSystem
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class WeaponView : MonoBehaviour
    {
        private WeaponController weaponController;
        [SerializeField] private Rigidbody2D rb;

        public void SetController(WeaponController weaponController)
        {
            this.weaponController = weaponController; 
        }

        public void Shoot(float force, Vector2 direction)
        {
            if (force > 30)
                force = 30;
            rb.AddForce(force * direction, ForceMode2D.Impulse);
        }
    }
}