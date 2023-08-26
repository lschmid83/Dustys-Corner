using DustysCorner.Client.Operations;
using DustysCorner.Client.Operations.Interfaces;

namespace DustysCorner.Client
{
    public class WebApiCalls : IWebApiCalls
    {
        private readonly ApiSettings ApiSettings;

        public WebApiCalls(ApiSettings apiSettings)
        {
            ApiSettings = apiSettings;
        }

        public ICategoryOperations GetCategory()
        {
            return new CategoryOperations(ApiSettings);
        }

        public IEventOperations GetEvent()
        {
            return new EventOperations(ApiSettings);
        }

        public IProductOperations GetProduct()
        {
            return new ProductOperations(ApiSettings);
        }

        public IReviewOperations GetReview()
        {
            return new ReviewOperations(ApiSettings);
        }

        public IGalleryOperations GetGallery()
        {
            return new GalleryOperations(ApiSettings);
        }

        public ISocialMediaOperations GetSocialMedia()
        {
            return new SocialMediaOperations(ApiSettings);
        }
    }
}
