using FloatDoor.Application.InputModels;
using FloatDoor.Application.Services.Interfaces;
using FloatDoor.Application.ViewModels;
using FloatDoor.Core.Entities;
using FloatDoor.Infrastructure.Persistence;
using System.Linq;

namespace FloatDoor.Application.Services.Implementations
{
    public class RentRequestService : IRentRequestService
    {
        private readonly FloatDoorDbContext _context;
        public RentRequestService(FloatDoorDbContext context)
        {
            _context = context;
        }

        public RequestDetailsViewModel GetRequestById(int id)
        {
            var request = _context.Rents.SingleOrDefault(r => r.Id == id);

            var requestVM = new RequestDetailsViewModel(request.Id, request.IdFloat, request.IdUser, request.RentDate, request.Message);

            return requestVM;
        }

        public int CreateRequest(CreateRequestInputModel inputModel)
        {
            var request = new RentRequest(inputModel.IdFloat, inputModel.IdUser, inputModel.RentDate, inputModel.Message);
            _context.Rents.Add(request);

            return request.Id;
        }

        public void UpdateRequest(UpdateRequestInputModel inputModel)
        {
            var request = _context.Rents.SingleOrDefault(r => r.Id == inputModel.Id);
            request.Update(request.RentDate, request.Message);
        }

        public void RejectRequest(int id)
        {
            var request = _context.Rents.SingleOrDefault(r => r.Id == id);
            request.Reject();
        }

        public void ApproveRequest(int id)
        {
            var request = _context.Rents.SingleOrDefault(r => r.Id == id);
            request.Approve();
        }        
    }
}
