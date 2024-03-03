using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace Azim.IDP;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        { 
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
            new IdentityResources.Phone(),
            new IdentityResource("roles",
                "Your Role(s)",
                new[] { "role" }),
            new IdentityResource("country", "country you're living in",
                new List<string>() { "country" })
        };
    public static IEnumerable<ApiResource> ApiResources =>
        new ApiResource[]
        {
            new ApiResource("imagegalleryapi", "Image Gallary API",
                new[] {"role", "country"})
            {
                Scopes = { "imagegalleryapi.fullaccess", 
                    "imagegalleryapi.read",
                    "imagegalleryapi.read"},
                ApiSecrets  = { new  Secret("apisecret".Sha256()) }
            }
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
            {
                new ApiScope("imagegalleryapi.fullaccess"),
                new ApiScope("imagegalleryapi.read"),
                new ApiScope("imagegalleryapi.write")
            };

    public static IEnumerable<Client> Clients =>
        new Client[] 
            {
                new Client()
                {
                    ClientName = "ImageGallary",
                    ClientId = "imagegalleryclient",
                    AllowedGrantTypes = GrantTypes.Code,
                    AccessTokenLifetime = 120,
                    AllowOfflineAccess = true,
                    AccessTokenType = AccessTokenType.Reference,
                    UpdateAccessTokenClaimsOnRefresh = true,
                    RedirectUris =
                    {
                        "https://localhost:7184/signin-oidc"
                    },
                    PostLogoutRedirectUris =
                    {
                        "https://localhost:7184/signout-callback-oidc"
                    },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Phone,
                        IdentityServerConstants.StandardScopes.Email,
                        "roles",
                        "country",
                        //"imagegalleryapi.fullaccess",
                        "imagegalleryapi.read",
                        "imagegalleryapi.write"
                    },
                    ClientSecrets = {new Secret("secret".Sha256())},
                    RequireConsent = true
                }
            };
}