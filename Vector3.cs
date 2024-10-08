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
            return Mathf.sqrt((this.X * this.X) + (this.Y * this.Y) + (this.Z * this.Z));
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

        public static Vector3 operator += (Vector3 u)
        {
            this.X += u.X;
            this.Y += u.Y;
            this.Z += u.Z;
            return this;
        }

        public static Vector3 operator -= (Vector3 u)
        {
            this.X -= u.X;
            this.Y -= u.Y;
            this.Z -= u.Z;
            return this;
        }

        public static Vector3 operator *= (float s)
        {
            this.X *= s;
            this.Y *= s;
            this.Z *= s;
            return this;
        }

        public static Vector3 operator /= (float s)
        {
            this.X /= s;
            this.Y /= s;
            this.Z /= s;
            return this;
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

        public static implicit operator UnityEngine.Vector3(Vector3 v)
        {
            return new UnityEngine.Vector3(v.X, v.Y, v.Z);
        }
        #endregion
    }
}