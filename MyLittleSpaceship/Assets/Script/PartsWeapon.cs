using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Part
{
    enum WeaponType
    {
        Normal,
        Damage,
        Covariance
    }
    public class PartsWeapon : Parts
    {
        int _damage;
        float _reloadTime;

        public PartsWeapon(Position position, int hp) : base(position, hp) { }

        void Shot()
        {

        }
    }
}