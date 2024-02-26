﻿using ImageGallery.API.Services;
using Microsoft.AspNetCore.Authorization;

namespace ImageGallery.API.Authorization
{
    public class MustOwnImageHandler : AuthorizationHandler<MustOwnImageRequirment>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IGalleryRepository _galleryRepository;
        public MustOwnImageHandler(
            IHttpContextAccessor httpContextAccessor,
            IGalleryRepository galleryRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _galleryRepository = galleryRepository;
        }

        public IHttpContextAccessor HttpContextAccessor { get; }

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            MustOwnImageRequirment requirement)
        {
            var imageId = _httpContextAccessor.HttpContext?
                .GetRouteValue("id")?
                .ToString();

            if(!Guid.TryParse(imageId, out Guid imageIdAsGuid))
            {
                context.Fail();
                return;
            }

            var ownerId = context.User.Claims
                .FirstOrDefault(c => c.Type == "sub")?.Value;
            if (ownerId == null)
            {
                context.Fail();
                return;
            }
            if(!await _galleryRepository.IsImageOwnerAsync(imageIdAsGuid, ownerId))
            {
                context.Fail();
                return;
            }

            context.Succeed(requirement);
        }
    }
}
