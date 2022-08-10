using FloatDoor.Application.InputModels;
using FloatDoor.Application.ViewModels;
using System.Collections.Generic;

namespace FloatDoor.Application.Services.Interfaces
{
    public interface IFloatService 
    {
        List<FloatsViewModel> GetAllFloats();
        FloatDetailsViewModel GetFloatById(int id);
        int CreateFloat(CreateFloatInputModel inputModel);
        void UpdateFloat(UpdateFloatInputModel inputModel);
        void DeleteFloat(int id);      
    }
}
