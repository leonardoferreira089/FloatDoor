using FloatDoor.Application.InputModels;
using FloatDoor.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
