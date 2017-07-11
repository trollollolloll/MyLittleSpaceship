using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Part
{
    enum ArmourType
    {
        Normal,
        Hp,
        Refair,
    }

    public class PartsArmour : PartsCore
    {
        public PartsArmour(Position position, int hp) : base(position, hp) { }
    }
}