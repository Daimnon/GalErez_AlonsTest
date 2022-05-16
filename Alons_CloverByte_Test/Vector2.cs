using System;
using System.Collections.Generic;
using System.Text;

namespace Alons_CloverByte_Test
{
    public struct Vector2
    {
        #region Fields
        float _x, _y;
        #endregion

        #region Static Fields
        static Vector2 _zero = new Vector2(0, 0);
        #endregion

        #region Properties
        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
        #endregion

        #region Static Properties
        public static Vector2 Zero => _zero;
        #endregion

        #region Constructor
        public Vector2(float x, float y)
        {
            //initialize Vector2
            _x = x;
            _y = y;
        }
        #endregion

        #region Methods
        public Vector2 Add(Vector2 newVector2)
        {
            Vector2 AddVector2 = new Vector2(X + newVector2.X, Y + newVector2.Y);
            return AddVector2;
        }
        public Vector2 Sub(Vector2 newVector2)
        {
            Vector2 SubVector2 = new Vector2(X - newVector2.X, Y - newVector2.Y);
            return SubVector2;
        }
        public Vector2 Set(Vector2 newVector2)
        {
            Vector2 replacedVector2 = newVector2;
            return replacedVector2;
        }
        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            if (this == (Vector2)obj)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        public override int GetHashCode()
        {
            int hashCode = -1489584576;
            hashCode = hashCode * -1521134295 + _x.GetHashCode();
            hashCode = hashCode * -1521134295 + _y.GetHashCode();
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            hashCode = hashCode * -1521134295 + Zero.GetHashCode();
            return hashCode;
        }
        #endregion

        #region Operators
        public static Vector2 operator +(Vector2 firstVector2, Vector2 secondVector2)
        {
            Vector2 result = new Vector2(firstVector2.X + secondVector2.X, firstVector2.Y + secondVector2.Y);
            return result;
        }
        public static Vector2 operator -(Vector2 firstVector2, Vector2 secondVector2)
        {
            Vector2 result = new Vector2(firstVector2.X - secondVector2.X, firstVector2.Y - secondVector2.Y);
            return result;
        }
        public static Vector2 operator *(Vector2 firstVector2, Vector2 secondVector2)
        {
            Vector2 result = new Vector2(firstVector2.X * secondVector2.X, firstVector2.Y * secondVector2.Y);
            return result;
        }
        public static Vector2 operator /(Vector2 firstVector2, Vector2 secondVector2)
        {
            Vector2 result = new Vector2(firstVector2.X / secondVector2.X, firstVector2.Y / secondVector2.Y);
            return result;
        }

        public static Vector2 operator *(Vector2 vector, float value)
        {
            Vector2 result = new Vector2(vector.X * value, vector.Y * value);
            return result;
        }
        public static bool operator ==(Vector2 firstVector2, Vector2 secondVector2)
        {
            if (firstVector2 == secondVector2)
                return true;
            else
                return false;
        }
        public static bool operator !=(Vector2 firstVector2, Vector2 secondVector2)
        {
            if (firstVector2 != secondVector2)
                return true;
            else
                return false;
        }
        public static bool operator >(Vector2 firstVector2, Vector2 secondVector2)
        {
            if (firstVector2 > secondVector2)
                return true;
            else
                return false;
        }
        public static bool operator <(Vector2 firstVector2, Vector2 secondVector2)
        {
            if (firstVector2 < secondVector2)
                return true;
            else
                return false;
        }
        public static bool operator >=(Vector2 firstVector2, Vector2 secondVector2)
        {
            if (firstVector2 >= secondVector2)
                return true;
            else
                return false;
        }
        public static bool operator <=(Vector2 firstVector2, Vector2 secondVector2)
        {
            if (firstVector2 <= secondVector2)
                return true;
            else
                return false;
        }
        #endregion
    }
}
