using CloudinaryDotNet.Actions;

namespace API.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> UpLoadPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
