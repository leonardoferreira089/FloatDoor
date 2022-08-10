using FloatDoor.Application.InputModels;
using FloatDoor.Application.Services.Interfaces;
using FloatDoor.Application.ViewModels;
using FloatDoor.Core.Entities;
using FloatDoor.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace FloatDoor.Application.Services.Implementations
{
    public class FloatService : IFloatService
    {
        private readonly FloatDoorDbContext _context;
        public FloatService(FloatDoorDbContext context)
        {
            _context = context;
        }

        public List<FloatsViewModel> GetAllFloats()
        {
            var floats = _context.Floats;
            var floatsVM = floats.Select(f => new FloatsViewModel(f.Id, f.FloatName, f.Price)).ToList();

            return floatsVM;
        }

        public FloatDetailsViewModel GetFloatById(int id)
        {
            var floatOne = _context.Floats.SingleOrDefault(f => f.Id == id);
            var floatVM = new FloatDetailsViewModel(floatOne.Id, floatOne.FloatName, floatOne.Description, floatOne.Price);

            return floatVM;
        }

        public int CreateFloat(CreateFloatInputModel inputModel)
        {
            var floatOne = new Float(inputModel.FloatName,
                inputModel.Description,
                inputModel.Email,
                inputModel.PhoneNumber,
                inputModel.Price,
                inputModel.IdCustomer,
                inputModel.IdFloatOwner);
            _context.Floats.Add(floatOne);

            return floatOne.Id;
        }

        public void UpdateFloat(UpdateFloatInputModel inputModel)
        {
            var floatUp = _context.Floats.SingleOrDefault(f => f.Id == inputModel.Id);
            floatUp.Update(floatUp.FloatName, floatUp.Email, floatUp.PhoneNumber, floatUp.Price);
        }

        public void DeleteFloat(int id)
        {
            var floatObj = _context.Floats.SingleOrDefault(f => f.Id == id);
            floatObj.Disabled();
        }             
    }
}
