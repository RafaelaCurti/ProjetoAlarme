using AutoMapper;
using ProjetoAlarme.Application.ViewModels;
using ProjetoAlarme.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAlarme.Presentation.Web.MVC.AutoMaper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMapping"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<AlarmeViewModel, Alarme>();
            Mapper.CreateMap<EquipamentoViewModel, Equipamento>();
        }
    }
}