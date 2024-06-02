using AutoMapper;
using FitFusion.BLL.Mapper;
using FitFusion.BLL.Services;
using FitFusion.BLL.VMs;
using FitFusion.Entity.NewEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FitFusion.UI.Controller;

public class PortionController
{
    private readonly PortionService _portionService;
    private readonly IMapper _mapper;
    public PortionController()
    {
        var config = new MapperConfiguration(cfg => { cfg.AddProfile<MapperProfile>(); });
        _mapper = config.CreateMapper();
        _portionService = new PortionService();
    }

    public void AddPortion ( string portionName, string portionDescription, int portionAmount)
    {
        Portion portion = new Portion()
        {
            Amount = portionAmount,
            PortionType = portionName
        };
        _portionService.Add(portion);
    }

    public List<PortionVm> GetPortions (Expression<Func<Portion, bool>> expression)
    {
        return _mapper.Map<List<PortionVm>>(_portionService.GetAll(expression));
    }
}
