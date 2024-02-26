// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

using IdentityModel;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace Azim.IDP;

public static class TestUsers
{
    public static List<TestUser> Users
    {
        get
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                    Username = "Azim",
                    Password = "Azimattya1231213",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.Name, "Abdalazim Attya"),
                        new Claim(JwtClaimTypes.GivenName, "Abdalazim"),
                        new Claim(JwtClaimTypes.FamilyName, "Attya"),
                        new Claim(JwtClaimTypes.Email, "Abdalazimattya.dev@email.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "http://alice.com"),
                        new Claim(JwtClaimTypes.PhoneNumber, "0532150994"),
                        new Claim(JwtClaimTypes.Role, "PayingUser"),
                        new Claim("country", "sud")
                    }
                },
                new TestUser
                {
                    SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                    Username = "bob",
                    Password = "bob",
                    Claims =
                    {
                        new Claim(JwtClaimTypes.Name, "Bob Smith"),
                        new Claim(JwtClaimTypes.GivenName, "Bob"),
                        new Claim(JwtClaimTypes.FamilyName, "Smith"),
                        new Claim(JwtClaimTypes.Email, "BobSmith@email.com"),
                        new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                        new Claim(JwtClaimTypes.WebSite, "http://bob.com"),
                        new Claim(JwtClaimTypes.PhoneNumber, "0557604177"),
                        new Claim(JwtClaimTypes.Role, "FreeUser"),
                        new Claim("country", "uae")
                    }
                }
            };
        }
    }
}