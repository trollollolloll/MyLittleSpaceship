using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Part
{
    public class PartsCore : Parts
    {
        public PartsCore(Position position, int hp) : base(position, hp) { }

        /// <summary>
        /// 파츠 붙이기
        /// </summary>
        /// <param name="direction"> 내가 도킹할 방향</param>
        /// <param name="parts"> 도킹할 파츠</param>
        public void DokingParts(Direction direction, Parts parts)
        {
            parts.SetPosition(direction, _position);

            switch (direction)
            {
                case Direction.Top:
                    _link.top = parts;
                    break;
                case Direction.Bottom:
                    _link.bottom = parts;
                    break;
                case Direction.Left:
                    _link.left = parts;
                    break;
                case Direction.Right:
                    _link.right = parts;
                    break;
                case Direction.Front:
                    _link.front = parts;
                    break;
                case Direction.Back:
                    _link.back = parts;
                    break;
            }
        }

        public override void Destroy()
        {
            base.Destroy();
        }
    }
}
