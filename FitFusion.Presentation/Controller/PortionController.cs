using AutoMapper;
using FitFusion.BLL.Mapper;
using FitFusion.BLL.Services;
using FitFusion.BLL.VMs;
using FitFusion.Entity.NewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.Presentation.Controller;

public class PortionController
{
    private readonly PortionService _portionService;
    private readonly IMapper _mapper;
    public PortionController()
    {
        _portionService = new PortionService();
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
        _mapper = config.CreateMapper();
    }

    public Portion GetPortion (PortionVm portionVm)
    {
        return _portionService.Get(portionVm.Id);
    }

    public List<PortionVm> GetPortionList ()
    {
        return _mapper.Map<List<PortionVm>>(_portionService.GetAll(x=> x.Statu!= Entity.Enums.Statu.Deleted));
    }

    public bool AddPortion (string portionType, int portionAmount)
    {

        if(portionAmount == 0 || portionType == string.Empty) 
        {
            MessageBox.Show("Please fill the all Portion fields!");
            return false;
        }
        else
        {
            Portion portion = new Portion()
            {
                Amount = portionAmount,
                PortionType = portionType
            };
            if (_portionService.Add(portion))
            {
                MessageBox.Show("The portion added succesfully!");
                return true;
            }
            else
            {
                return false;
            }
        }

        return false;

       
    }

    public void RemovePortion (Guid id)
    {
        var selectedPortion =_portionService.Get(id);
        _portionService.Delete(selectedPortion);
        MessageBox.Show("The portion deleted succesfully!");
    }

    public Portion GetPortion(Guid id)
    {
        return _portionService.Get(id);
    }

    public void UpdatePortion(Portion portion)
    {
       _portionService.Update(portion);
        MessageBox.Show("The portion updated succesfully!");

        
    }
}
