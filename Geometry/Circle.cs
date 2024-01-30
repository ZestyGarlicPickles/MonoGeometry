﻿using Microsoft.Xna.Framework;

namespace MonoGeometry.Geometry
{
    public struct Circle : IEquatable<Circle>
    {
        #region Public properties
        public Vector2 Center { get; set; }
        public float Radius { get; set; }
        public readonly float Perimeter => 2 * MathHelper.Pi * this.Radius;
        public readonly float Area => MathHelper.Pi * this.Radius * this.Radius;
        #endregion
        #region Constructors
        public Circle() : this(Vector2.Zero, 0f) { }
        public Circle(Vector2 center, float radius)
        {
            this.Center = center;
            this.Radius = radius;
        }
        #endregion
        #region Operators
        public static bool operator ==(Circle a, Circle b) => (a.Center == b.Center) && (a.Radius == b.Radius);
        public static bool operator !=(Circle a, Circle b) => !(a == b);
        #endregion
        #region Public methods
        public override readonly bool Equals(object? obj) => (obj is Circle circle) && (this == circle);
        public readonly bool Equals(Circle other) => this == other;
        public override readonly int GetHashCode() => HashCode.Combine(this.Center, this.Radius);
        public override readonly string ToString() => "{Center:" + this.Center.ToString() + "Radius:" + this.Radius.ToString() + "}";
        public readonly bool Contains(Vector2 point) => GeometryHelper.DistanceSquared(point, this.Center) <= this.Radius * this.Radius;
        public readonly bool Intersects(Circle other) => GeometryHelper.DistanceSquared(this.Center, other.Center) <= (this.Radius + other.Radius) * (this.Radius + other.Radius);
        public readonly Circle Translate(Vector2 delta)
        {
            Circle translated = this;
            translated.Center += delta;
            return translated;
        }
        public readonly Circle Scale(float factor)
        {
            Circle scaled = this;
            scaled.Radius *= factor;
            return scaled;
        }
        #endregion
    }
}
