using AutoMapper;
using ProjetoAlarme.Application.ViewModels;
using ProjetoAlarme.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAlarme.Presentation.Web.MVC.AutoMaper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMapping"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<Alarme, AlarmeViewModel>();
            Mapper.CreateMap<Equipamento, EquipamentoViewModel>();
        }
    }
}