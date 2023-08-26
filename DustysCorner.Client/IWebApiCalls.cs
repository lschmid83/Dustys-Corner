using DustysCorner.Client.Operations.Interfaces;

namespace DustysCorner.Client
{
    public interface IWebApiCalls
    {
        ICategoryOperations GetCategory();
        IEventOperations GetEvent();
        IProductOperations GetProduct();
        IReviewOperations GetReview();
        IGalleryOperations GetGallery();
        ISocialMediaOperations GetSocialMedia();
    }
}