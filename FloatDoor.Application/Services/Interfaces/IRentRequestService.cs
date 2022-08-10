using FloatDoor.Application.InputModels;
using FloatDoor.Application.ViewModels;

namespace FloatDoor.Application.Services.Interfaces
{
    public interface IRentRequestService
    {        
        RequestDetailsViewModel GetRequestById(int id);
        int CreateRequest(CreateRequestInputModel inputModel);
        void UpdateRequest(UpdateRequestInputModel inputModel);
        void RejectRequest(int id);
        void ApproveRequest(int id);
        
    }
}
