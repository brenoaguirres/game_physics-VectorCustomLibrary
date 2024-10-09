using System;
using UnityEngine;

namespace VectorCustom
{
    
    public class Vector3
    {
        #region CONSTRUCTOR
        public Vector3()
        {
            _x = 0f; _y = 0f; _z = 0f;
        }

        public Vector3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        #endregion

        #region FIELDS
        private float _x;
        private float _y;
        private float _z;
        #endregion

        #region PROPERTIES
        private float X { get { return X; } set { X = value; } }
        private float Y { get { return Y; } set { Y = value; } }
        private float Z { get { return Z; } set { Z = value; } }
        #endregion

        #region METHODS
        public float Magnitude()
        {
            return Mathf.Sqrt((this.X * this.X) + (this.Y * this.Y) + (this.Z * this.Z));
        }

        public void Normalize()
        {
            const float tol = 0.0001f;

            float m  = this.Magnitude();
            if (m <= tol) m = 1;
            this.X /= m;
            this.Y /= m;
            this.Z /= m;

            if (Mathf.Abs(X) < tol) this.X = 0.0f;
            if (Mathf.Abs(Y) < tol) this.Y = 0.0f;
            if (Mathf.Abs(Z) < tol) this.Z = 0.0f;
        }

        public void Reverse()
        {
            this.X = -X;
            this.Y = -Y;
            this.Z = -Z;
        }

        public float DirectionAngles()
        {

        }

        public Vector3 Dot(Vector3 u)
        {

        }

        public Vector3 Cross(Vector3 u)
        {

        }

        public float TripleScalarProduct(Vector3 u, Vector3 v, Vector3 w)
        {
            
        }
        #endregion

        #region STATIC METHODS
        public static Vector3 Zero()
        {
            return new Vector3(0, 0, 0);
        }

        public static Vector3 One()
        {
            return new Vector3(1, 1, 1);
        }
        
        public static Vector3 Up()
        {
            return new Vector3(0, 1, 0);
        }

        public static Vector3 Down()
        {
            return new Vector3(0, -1, 0);
        }

        public static Vector3 Right()
        {
            return new Vector3(1, 0, 0);
        }

        public static Vector3 Left()
        {
            return new Vector3(-1, 0, 0);
        }

        public static Vector3 Forward()
        {
            return new Vector3(0, 0, 1);
        }

        public static Vector3 Back()
        {
            return new Vector3(0, 0, -1);
        }
        #endregion

        #region OPERATORS
        public static Vector3 operator + (Vector3 u, Vector3 v)
        {
            return new Vector3(u.X + v.X, u.Y + v.Y, u.Z + v.Z);
        }

        public static Vector3 operator - (Vector3 u, Vector3 v)
        {
            return new Vector3(u.X - v.X, u.Y - v.Y, u.Z - v.Z);
        }

        public static Vector3 operator * (Vector3 u, float s)
        {
            return new Vector3(u.X * s, u.Y * s, u.Z * s);
        }

        public static Vector3 operator / (Vector3 u, float s)
        {
            return new Vector3(u.X / s, u.Y / s, u.Z / s);
        }
        
        public static Vector3 operator - (Vector3 u)
        {
            return new Vector3(-u.X, -u.Y, -u.Z);
        }

        public static Vector3 operator * (Vector3 u, Vector3 v)
        {
            // Dot
        }

        public static Vector3 operator ^ (Vector3 u, Vector3 v)
        {
            // Cross
        }
        #endregion

        #region TYPECAST
        public static explicit operator UnityEngine.Vector3(Vector3 v)
        {
            return new UnityEngine.Vector3(v.X, v.Y, v.Z);
        }

        public override string ToString()
        {
            return "Vector3: ( " + X + " , " + Y + " , " + Z + " )";
        }

        public static explicit operator Vector3(Vector2 v)
        {
            Debug.LogWarning("Warning: Conversion from Vector3 to Vector will result in loss of data on z axis.");
            return new Vector2(X, Y);
        }
        #endregion
    }
}