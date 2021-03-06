﻿//-----------------------------------------------------------------------
// <copyright file="RoleClaimDto.cs" company="Harbor Village">
//     Copyright (c) Harbor Village. All rights reserved.
// </copyright>
// <auto-generated />
// <author></author>
//-----------------------------------------------------------------------
namespace Nicollas.Dto.Identity
{
    using System;

    public class RoleClaimDto
    {
        /// <summary>
        /// Gets or sets the of the primary key of the role associated with this claim.
        /// </summary>
        public virtual Guid RoleId { get; set; }

        /// <summary>
        ///  Gets or sets the role
        /// </summary>
        public virtual RoleDto Role { get; set; }

        /// <summary>
        /// Gets or sets the claim type for this claim.
        /// </summary>
        public virtual string ClaimType { get; set; }

        /// <summary>
        /// Gets or sets the claim value for this claim.
        /// </summary>
        public virtual string ClaimValue { get; set; }
    }
}
