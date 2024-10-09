using UnityEngine;
using VectorCustom;

namespace VectorCustom
{
    [RequireComponent(typeof(LineRenderer))]
    public class VectorVisualizer : MonoBehaviour
    {
        #region FIELDS
        [SerializeField] private float _x = 1;
        [SerializeField] private float _y = 1;
        [SerializeField] private float _z = 1;
        private VectorCustom.Vector3 _vec3;
        #endregion

        #region REFERENCES
        [SerializeField] private LineRenderer _lineRenderer;
        #endregion

        #region DEFAULT METHODS
        private void Awake()
        {
            _vec3 = new(_x, _y, _z);

            _lineRenderer = GetComponent<LineRenderer>();
        }

        private void Start()
        {
            DrawVector(_vec3);
        }
        #endregion

        #region CUSTOM METHODS
        public void DrawVector(VectorCustom.Vector3 v)
        {
            //Transform transform = new Transform((UnityEngine.Vector3)v);

            // TODO: LineRenderer behavior
        }
        #endregion
    }
}