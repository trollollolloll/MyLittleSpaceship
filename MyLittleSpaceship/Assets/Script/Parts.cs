using UnityEngine;
using System.Collections;

namespace Part
{
    public class Parts : MonoBehaviour
    {
        protected Position _position;
        protected Link _link;
        private PartsType _type;
        private int _maxHp;
        private int _curruntHp;


        public Parts(Position position, int hp)
        {
            _position = position;
            _maxHp = hp;
            _curruntHp = hp;
        }

        public Position position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        public Link link
        {
            get
            {
                return _link;
            }
            set
            {
                _link = value;
            }
        }

        public int hp
        {
            get
            {
                return _maxHp;
            }
            set
            {
                _maxHp = value;
            }
        }

        public PartsType type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public void SetPosition(Direction dir, Position standard)
        {
            switch (dir)
            {
                case Direction.Top:
                    _position.x = standard.x;
                    _position.y = standard.y + 1;
                    _position.z = standard.z;
                    break;
                case Direction.Bottom:
                    _position.x = standard.x;
                    _position.y = standard.y - 1;
                    _position.z = standard.z;
                    break;
                case Direction.Left:
                    _position.x = standard.x - 1;
                    _position.y = standard.y;
                    _position.z = standard.z;
                    break;
                case Direction.Right:
                    _position.x = standard.x + 1;
                    _position.y = standard.y;
                    _position.z = standard.z;
                    break;
                case Direction.Front:
                    _position.x = standard.x;
                    _position.y = standard.y;
                    _position.z = standard.z + 1;
                    break;
                case Direction.Back:
                    _position.x = standard.x;
                    _position.y = standard.y;
                    _position.z = standard.z - 1;
                    break;
            }
        }

        public virtual void Destroy()
        {

        }

    }
}