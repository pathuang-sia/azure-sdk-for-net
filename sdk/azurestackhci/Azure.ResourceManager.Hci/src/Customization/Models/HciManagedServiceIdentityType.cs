// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed). </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public readonly partial struct HciManagedServiceIdentityType : IEquatable<HciManagedServiceIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HciManagedServiceIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HciManagedServiceIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string SystemAssignedValue = "SystemAssigned";
        private const string UserAssignedValue = "UserAssigned";
        private const string SystemAssignedUserAssignedValue = "SystemAssigned, UserAssigned";

        /// <summary> None. </summary>
        public static HciManagedServiceIdentityType None { get; } = new HciManagedServiceIdentityType(NoneValue);
        /// <summary> SystemAssigned. </summary>
        public static HciManagedServiceIdentityType SystemAssigned { get; } = new HciManagedServiceIdentityType(SystemAssignedValue);
        /// <summary> UserAssigned. </summary>
        public static HciManagedServiceIdentityType UserAssigned { get; } = new HciManagedServiceIdentityType(UserAssignedValue);
        /// <summary> SystemAssigned, UserAssigned. </summary>
        public static HciManagedServiceIdentityType SystemAssignedUserAssigned { get; } = new HciManagedServiceIdentityType(SystemAssignedUserAssignedValue);
        /// <summary> Determines if two <see cref="HciManagedServiceIdentityType"/> values are the same. </summary>
        public static bool operator ==(HciManagedServiceIdentityType left, HciManagedServiceIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HciManagedServiceIdentityType"/> values are not the same. </summary>
        public static bool operator !=(HciManagedServiceIdentityType left, HciManagedServiceIdentityType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HciManagedServiceIdentityType"/>. </summary>
        public static implicit operator HciManagedServiceIdentityType(string value) => new HciManagedServiceIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HciManagedServiceIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HciManagedServiceIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
