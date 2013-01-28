namespace System.Spatial
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    internal abstract class GeometryLineString : GeometryCurve
    {
        protected GeometryLineString(CoordinateSystem coordinateSystem, SpatialImplementation creator) : base(coordinateSystem, creator)
        {
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as GeometryLineString);
        }

        public bool Equals(GeometryLineString other)
        {
            bool? nullable = base.BaseEquals(other);
            if (!nullable.HasValue)
            {
                return this.Points.SequenceEqual<GeometryPoint>(other.Points);
            }
            return nullable.GetValueOrDefault();
        }

        public override int GetHashCode()
        {
            return Geography.ComputeHashCodeFor<GeometryPoint>(base.CoordinateSystem, this.Points);
        }

        public abstract ReadOnlyCollection<GeometryPoint> Points { get; }
    }
}

