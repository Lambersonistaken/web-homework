using CloudinaryDotNet.Actions;

namespace webHomework.Interfaces
{
    public interface IPhotoService
    {

        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);

        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
